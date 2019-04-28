using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using JsonDataMaker.CsvMapper;
using Newtonsoft.Json;
using BankVision.WebAPI.Models.Common;
using JsonDataMaker.Models.GW0008.Request;
using JsonDataMaker.Models.GW0008.Response;
using jsondatamaker.Models;

namespace JsonDataMaker.Logic
{
    public class GW0008ResponseLogic : IGWLogic
    {
        private readonly CsvFetcher _readCsv;
        private readonly JsonFileWriter _jsonFileWriter;
        private const string apiNo = "GW0008";
        private const string response = "response";

        public GW0008ResponseLogic(CsvFetcher readCsv, JsonFileWriter jsonFileWriter)
        {
            _readCsv = readCsv;
            _jsonFileWriter = jsonFileWriter;
        }

        public void CreateData(string outputpath, CsvReader csv)
        {
            int i = 0;
            var data = _readCsv.Fetcher<GW0008ResponseJson, GW0008ResponseMapper>(csv);
            foreach (GW0008ResponseJson item in data)
            {
                // WisResponseSystemInfoクラスの生成
                item.ResponseMessageData.WisResponseSystemInfo = new WisResponseSystemInfoValue();

                // jsonデータ作成
                _jsonFileWriter.New(item.ResponseMessageData, item.FileNo, apiNo, response, outputpath);
                
                i++;
            }
            Console.WriteLine($"\n {i}件のファイルを出力しました");
        }

        public void CreateListData(string outputpath, CsvReader csv1, CsvReader csv2)
        {
            throw new NotImplementedException();
        }
    }
}