using System;
using System.IO;
using System.Text;
using CommandLine;
using CsvHelper;
using JsonDataMaker.Logic;

namespace JsonDataMaker
{
    class Program
    {
        private static string response = "response";
        private static string request = "request";
        private static LogicFactory _logicFactory = new LogicFactory();

        static void Main(string[] args)
        {
            Console.WriteLine("\n 処理を開始します");

            try
            {
                Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(o =>
                {
                    //入力パラメータの検査
                    var reqOrRes = o.reqOrRes.ToLower();

                    if (reqOrRes != response && reqOrRes != request)
                        throw new InvalidDataException("\n RequestかResponseをして下さい");

                    // CsvReader生成
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    var reader1 = new StreamReader(o.file1Name, Encoding.GetEncoding("shift-jis"));
                    var csv1 = new CsvReader(reader1);

                    var cf = new CsvFetcher();
                    var jf = new JsonFileWriter();

                    IGWLogic _iGWLogic;

                    _iGWLogic = _logicFactory.CreateLogic(o.apiNo, reqOrRes, cf, jf);

                    // listファイルがある場合
                    if (o.file2Name != null)
                    {
                        var reader2 = new StreamReader(o.file2Name, Encoding.GetEncoding("shift-jis"));
                        var csv2 = new CsvReader(reader2);
                        _iGWLogic.CreateListData(o.outputpath, csv1, csv2);
                    }
                    // mainファイルのみの場合
                    else
                    {
                        _iGWLogic.CreateData(o.outputpath, csv1);
                    }
                });
                Console.WriteLine("\n 正常に終了しました");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n エラーが発生しました");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
