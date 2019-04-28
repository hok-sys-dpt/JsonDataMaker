using System;
using CsvHelper;
using JsonDataMaker.CsvMapper;
using Newtonsoft.Json;
using JsonDataMaker.Models.GW1002.Response;
using System.Linq;
using jsondatamaker.Models;
using jsondatamaker.Models.GW1002.Response;
using BankVision.WebAPI.Models.GW1002.Response;

namespace JsonDataMaker.Logic
{
    public class GW1002ResponseLogic : IGWLogic
    {
        private readonly CsvFetcher _readCsv;
        private readonly JsonFileWriter _jsonFileWriter;
        private const string apiNo = "GW1002";
        private const string response = "response";
        private const int MaxItemCount = 50;

        public GW1002ResponseLogic(CsvFetcher readCsv, JsonFileWriter jsonFileWriter)
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

            // CsvをFetch
            var data1 = _readCsv.Fetcher<GW1002ResponseJson, GW1002ResponseMapper>(csv1);
            var data2 = _readCsv.Fetcher<GW1002ResponseList, GW1002ResponseListMapper>(csv2);

            foreach (GW1002ResponseJson item in data1)
            {
                // WisResponseSystemInfoクラスの生成
                item.ResponseMessageData.WisResponseSystemInfo = new WisResponseSystemInfoValue();

                // 基本ファイルのFileIdと一致する明細ファイルのレコードを抽出
                var selectedData = data2.Where(d => d.FileId == item.FileNo)
                                        .Select(s => s.RiyoKozaJoho)
                                        .ToArray();

                // 利用口座情報に抽出データを設定
                var c = 0;
                foreach (RiyoKozaJoho koza in selectedData)
                {
                    item.ResponseMessageData.BizIbRiyoukozaShokai.RiyoKozaJoho[c] = koza;
                    c++;
                }

                // 空文字で配列を埋める
                for (var a = c - 1; a < MaxItemCount; a++)
                {
                    item.ResponseMessageData.BizIbRiyoukozaShokai.RiyoKozaJoho[a] = new RiyoKozaJohoEmpty();
                }

                // jsonファイル作成
                _jsonFileWriter.New(item.ResponseMessageData, item.FileNo, apiNo, response, outputpath);

                i++;
            }
            Console.WriteLine($"\n {i}件のファイルを出力しました");
        }
    }
}