using System;
using System.IO;
using System.Reflection;
using System.Text;
using Autofac;
using Autofac.Configuration;
using CommandLine;
using CsvHelper;
using Hox.Biz.BankAccount.Domain;
using JsonDataMaker.Logic;
using Microsoft.Extensions.Configuration;

namespace JsonDataMaker
{
    class Program
    {
        private static string response = "response";
        private static string request = "request";

        internal static IContainer Container
        {
            get; private set;
        }

        static void Main(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("EnvironmentName") ?? "Production";
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddJsonFile("components.json", optional: true)
                .AddJsonFile($"components.{environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            var module = new ConfigurationModule(configuration);
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            Container = builder.Build();

            var sample = configuration.GetSection("Sample").Get<SampleSettings>();
            Console.WriteLine(sample.ItemA);
            Console.WriteLine(sample.ItemB);
            Console.WriteLine(sample.ItemC);

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

                    IGWLogic _iGWLogic = _iGWLogic = Container.Resolve<LogicFactory>().CreateLogic(o.apiNo, reqOrRes);

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
