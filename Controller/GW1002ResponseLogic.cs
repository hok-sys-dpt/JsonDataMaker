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
using JsonDataMaker.Models.GW1012.Response;
using System.Linq;

namespace JsonDataMaker.Controller
{
    public class GW1002ResponseLogic : IGWLogic
    {
        private readonly ReadCsv _readCsv;
        private readonly JsonFileWriter _jsonFileWriter;
        private const string apiNo = "GW1002";
        private const string request = "request";
        private const string response = "response";

        public GW1002ResponseLogic(ReadCsv readCsv, JsonFileWriter jsonFileWriter)
        {
            _readCsv = readCsv;
            _jsonFileWriter = jsonFileWriter;
        }

        public void CreateData(string outputpath, CsvReader csv)
        {
            throw new NotImplementedException();

        }

        public void CreateListData(string outputpath, CsvReader csv1, CsvReader csv2)
        {
            int i = 0;
            var data1 = _readCsv.Fetcher<GW1002ResponseJson, GW1002ResponseMapper>(csv1);
            foreach (GW1002ResponseJson item in data1)
            {
                item.ResponseMessageData.WisResponseSystemInfo = new WisResponseSystemInfo()
                {
                    version = "",
                    transactionId = "51-1_1goSKY002KjZ",
                    result = 0,
                    resultCode = "000000",
                    resultDetail = null
                };
                var data2 = _readCsv.Fetcher<GW1002ResponseList, GW1002ResponseListMapper>(csv2);
                var selectedData = data2.Cast<GW1002ResponseList>().Where(d => d.FileId == item.FileNo);
                Console.WriteLine(selectedData.ToString());

                // foreach (GW1002ResponseList item2 in data2)
                // {
                //     if(item2.FileId == item.FileNo)
                //     {
                //         item.ResponseMessageData.BizIbRiyoukozaShokai.RiyoKozaJoho = item2.RiyoKozaJoho;
                //     }

                // }
                // _jsonFileWriter.New(item.RequestMessageData, item.FileNo, apiNo, request, outputpath);
                // i++;
            }
            Console.WriteLine($"\n {i}件のファイルを出力しました");
        }
    }
}