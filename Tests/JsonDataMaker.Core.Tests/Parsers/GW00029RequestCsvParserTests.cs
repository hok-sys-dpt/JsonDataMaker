
using BankVision.WebAPI.Models.GW0029;
using BankVision.WebAPI.Models.GW0029.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0029RequestCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0029RequestCsvParser();

            var csv = new StringBuilder();
            foreach (string line in GetCsvStrings())
            {
                csv.AppendLine(line);
            }

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv.ToString()));
            var actual = target.Parse(stream);

            var expected = new List<Root<RequestMessageData>>()
            {
                new Root<RequestMessageData>()
                {
                    FileId = 1001,
                    Data = new RequestMessageData()
                    {
                        Teikiyokinshiharai = new Teikiyokinshiharai()
                        {
                            IbTeikiShohinKaiyakuYokyu = new IbTeikiShohinKaiyakuYokyu()
                            {
                                shohinShubetsu = 1002,
                                nyukinKozaTemban = 1003,
                                nyukinKozaKamokuCode = 1004,
                                nyukinKozabango = 1005,
                                teikiTemban = 1006,
                                teikiKamokuCode = 1007,
                                teikiKamokuCodechiwake = 1008,
                                teikiKozabango = 1009,
                                yonyuBango = 1010,
                                uketsukeKingaku = 1011,
                                kakuninJikkoKubun = 1012,
                                shiharaibi = "1013",
                            },
                            KensaKomoku = new KensaKomoku()
                            {
                                keiyakushaId = 1014,
                            },
                        },
                    },
                },
                 new Root<RequestMessageData>()
                {
                    FileId = 1101,
                    Data = new RequestMessageData()
                    {
                        Teikiyokinshiharai = new Teikiyokinshiharai()
                        {
                            IbTeikiShohinKaiyakuYokyu = new IbTeikiShohinKaiyakuYokyu()
                            {
                                shohinShubetsu = 1102,
                                nyukinKozaTemban = 1103,
                                nyukinKozaKamokuCode = 1104,
                                nyukinKozabango = 1105,
                                teikiTemban = 1106,
                                teikiKamokuCode = 1107,
                                teikiKamokuCodechiwake = 1108,
                                teikiKozabango = 1109,
                                yonyuBango = 1110,
                                uketsukeKingaku = 1111,
                                kakuninJikkoKubun = 1112,
                                shiharaibi = "1113",
                            },
                            KensaKomoku = new KensaKomoku()
                            {
                                keiyakushaId = 1114,
                            },
                        },
                    },
                },
                new Root<RequestMessageData>()
                {
                    FileId = 1201,
                    Data = new RequestMessageData()
                    {
                        Teikiyokinshiharai = new Teikiyokinshiharai()
                        {
                            IbTeikiShohinKaiyakuYokyu = new IbTeikiShohinKaiyakuYokyu()
                            {
                                shohinShubetsu = 1202,
                                nyukinKozaTemban = 1203,
                                nyukinKozaKamokuCode = 1204,
                                nyukinKozabango = 1205,
                                teikiTemban = 1206,
                                teikiKamokuCode = 1207,
                                teikiKamokuCodechiwake = 1208,
                                teikiKozabango = 1209,
                                yonyuBango = 1210,
                                uketsukeKingaku = 1211,
                                kakuninJikkoKubun = 1212,
                                shiharaibi = "1213",
                            },
                            KensaKomoku = new KensaKomoku()
                            {
                                keiyakushaId = 1214,
                            },
                        },
                    },
                },
            };

            actual.Is(expected, new JsonComparer());
        }

        private IEnumerable<string> GetCsvStrings()
        {
            // ヘッダ部
            yield return "FileId,shohinShubetsu,nyukinKozaTemban,nyukinKozaKamokuCode,nyukinKozabango,teikiTemban,teikiKamokuCode,teikiKamokuCodechiwake,teikiKozabango,yonyuBango,uketsukeKingaku,kakuninJikkoKubun,shiharaibi";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014";
            yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113,1114";
            yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213,1214";
        }
    }
}
