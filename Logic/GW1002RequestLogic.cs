using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using JsonDataMaker.CsvMapper;
using Newtonsoft.Json;
using BankVision.WebAPI.Models.Common;
using JsonDataMaker.Models.GW1002.Request;
using JsonDataMaker.Models.GW1002.Response;
using jsondatamaker.Models;

namespace JsonDataMaker.Logic
{
    public class GW1002RequestLogic : IGWLogic
    {
        private readonly CsvFetcher _readCsv;
        private readonly JsonFileWriter _jsonFileWriter;
        private const string apiNo = "GW1002";
        private const string request = "request";
        private const string response = "response";

        public GW1002RequestLogic(CsvFetcher readCsv, JsonFileWriter jsonFileWriter)
        {
            _readCsv = readCsv;
            _jsonFileWriter = jsonFileWriter;
        }

        public void CreateData(string outputpath, CsvReader csv)
        {
            int i = 0;

            // CsvからFetch
            var data = _readCsv.Fetcher<GW1002RequestJson, GW1002RequestMapper>(csv);

            foreach (GW1002RequestJson item in data)
            {
                // WisRequestSystemInfoクラスの生成
                item.RequestMessageData.WisRequestSystemInfo = new WisRequestSystemInfoValue();

                // jsonファイル作成
                _jsonFileWriter.New(item.RequestMessageData, item.FileNo, apiNo, request, outputpath);

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