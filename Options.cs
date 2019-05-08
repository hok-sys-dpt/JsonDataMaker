using System.Collections.Generic;
using CommandLine;

namespace JsonDataMaker
{
    public class Options
    {
        [Option('a', "apino", Required = true, HelpText = "API番号 GWxxxx")]
        public string apiNo { get; set; }

        [Option('r', "io", Required = true, HelpText = "Request/Response")]
        public string reqOrRes { get; set; }

        [Option('m', "mainfile", Required = true, HelpText = "基本ファイル")]
        public string file1Name { get; set; }

        [Option('l', "listfile", Required = false, HelpText = "明細ファイル　反復項目がある場合のみ指定して下さい")]
        public string file2Name { get; set; }

        [Option('o', "outputpath", Required = true, HelpText = "ファイル出力先の絶対パス")]
        public string outputpath { get; set; }
    }
}