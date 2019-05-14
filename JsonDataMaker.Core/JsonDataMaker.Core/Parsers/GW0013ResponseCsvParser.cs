using BankVision.WebAPI.Models.GW0013.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0013ResponseCsvParser : ICsvParser<Root<ResponseMessageData>>
    {
        private const int MeisaiJohoCount = 20;

        private static readonly MeisaiJoho DefaultMeisaiJoho = new MeisaiJoho()
        {
            sequence = String.Empty,
            torihikibi = String.Empty,
            torihikiJikoku = String.Empty,
            iriharaiKubun = 0,
            torihikiKingaku = Decimal.Zero,
            hyomenZandaka = Decimal.Zero,
            tsukaCode = String.Empty,
            tsukaMeisho = String.Empty,
            tekiyoKanji = String.Empty,
            tekiyoKana = String.Empty,
        };

        public IEnumerable<Root<ResponseMessageData>> Parse(params Stream[] streams)
        {
            if (streams.Length != 2) { throw new ArgumentException(nameof(streams)); }

            var parentParser = new CsvParser<Root<ResponseMessageData>, GW0013ResponseMap>();
            var parents = parentParser.Parse(streams[0]);

            var childParser = new CsvParser<MeisaiJoho, GW0013MeisaiJohoMap>();
            var children = childParser.Parse(streams[1]).ToList();

            if (children.Count > MeisaiJohoCount) { throw new ArgumentException(nameof(streams)); }

            for (int count = children.Count; count < MeisaiJohoCount; count++)
            {
                children.Add(DefaultMeisaiJoho);
            }

            foreach (var item in parents)
            {
                item.Data.GaikaYokinNyushukkinMeisaiShokai.MeisaiJoho =
                    JsonConvert.DeserializeObject<MeisaiJoho[]>(JsonConvert.SerializeObject(children));
            }
            return parents;
        }

        public IEnumerable<Root<ResponseMessageData>> Parse(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
