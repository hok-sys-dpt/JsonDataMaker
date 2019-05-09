using CsvHelper;
using jsondatamaker.Models;
using JsonDataMaker;
using JsonDataMaker.CsvMapper;
using JsonDataMaker.Models.GW0008.Request;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace jsondatamaker.Parser
{
    public class GW0008RequestCsvParser
    {
        public CsvFetcher _csvFetcher { get; set; }

        public GW0008RequestCsvParser()
        {
            _csvFetcher = new CsvFetcher();
        }

        public IEnumerable<GW0008RequestJson> Parse(FileStream csvFileStream)
        {
            // ファイル読み込み
            using (var streamReader = new StreamReader(csvFileStream, Encoding.UTF8))
            using (var csvReader = new CsvReader(streamReader))
            {
                var jsons = _csvFetcher.Fetcher<GW0008RequestJson, GW0008RequestMapper>(csvReader);
                // エントリごとに、WisRequestSystemInfoクラスを生成
                foreach (GW0008RequestJson json in jsons)
                {
                    json.RequestMessageData.WisRequestSystemInfo = new WisRequestSystemInfoValue();
                }

                return jsons;
            }
        }
    }
}
