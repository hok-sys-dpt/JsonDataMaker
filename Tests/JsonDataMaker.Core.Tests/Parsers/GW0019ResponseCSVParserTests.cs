using BankVision.WebAPI.Models.GW0019.Response;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Xunit;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0019ResponseCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0019ResponseCsvParser();

            var csv = new StringBuilder();
            foreach (string line in GetCsvStrings())
            {
                csv.AppendLine(line);
            }

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv.ToString()));
            var actual = target.Parse(stream);

            var expected = new List<Root<ResponseMessageData>>()
            {
                new Root<ResponseMessageData>()
                {
                    FileId=1001,
                    Data = new ResponseMessageData()
                    {
                        HurikomisakiKozaShokai = new HurikomisakiKozaShokai()
                        {
                            shoribi = "1002",
                            shoriJikoku = "1003",
                            HurikomisakiKozaShokaiOto = new HurikomisakiKozaShokaiOto()
                            {
                                hurikomiJisshiKahi = 1004,
                                shokaiKekkaChikanKubun = 1005,
                                kozaKakuninTRXID = "1006",
                                UketorininJoho = new UketorininJoho()
                                {
                                    uketorininKinyukikanCode = 1007,
                                    uketorininKinyukikanmeiKana = "1008",
                                    uketorininKinyukikanmeiKanji = "1009",
                                    uketorininShitenCode = 1010,
                                    uketorininShitenmeiKana = "1011",
                                    uketorininShitenmeiKanji = "1012",
                                    uketorininKamokuCode = 1013,
                                    uketorininKamokumei = "1014",
                                    uketorininKozabango = 1015,
                                    uketorininKanaShimei ="1016",
                                },

                            },
                        },
                    },

            //        new Root<ResponseMessageData>()
            //        {
            //            FileId=1101,
            //            HurikomisakiKozaShokai = new HurikomisakiKozaShokai()
            //            {
            //                shoribi = "1102",
            //                shoriJikoku = "1103",
            //                HurikomisakiKozaShokaiOto = new HurikomisakiKozaShokaiOto()
            //                {
            //                    hurikomiJisshiKahi = 1104,
            //                    shokaiKekkaChikanKubun = 1105,
            //                    kozaKakuninTRXID = "1106",
            //                    UketorininJoho = new UketorininJoho()
            //                    {
            //                        uketorininKinyukikanCode = 1107,
            //                        uketorininKinyukikanmeiKana = "1108",
            //                        uketorininKinyukikanmeiKanji = "1109",
            //                        uketorininShitenCode = 1110,
            //                        uketorininShitenmeiKana = "1111",
            //                        uketorininShitenmeiKanji = "1112",
            //                        uketorininKamokuCode = 1113,
            //                        uketorininKamokumei = "1114",
            //                        uketorininKozabango = 1115,
            //                        uketorininKanaShimei ="1116",
            //                },

            //            },
            //        },
            //    },
            //    new Root<ResponseMessageData>()
            //    {
            //        FileId=1101,
            //        HurikomisakiKozaShokai = new HurikomisakiKozaShokai()
            //        {
            //            shoribi = "1202",
            //            shoriJikoku = "1203",
            //            HurikomisakiKozaShokaiOto = new HurikomisakiKozaShokaiOto()
            //            {
            //                hurikomiJisshiKahi = 1204,
            //                shokaiKekkaChikanKubun = 1205,
            //                kozaKakuninTRXID = "1206",
            //                UketorininJoho = new UketorininJoho()
            //                {
            //                    uketorininKinyukikanCode = 1207,
            //                    uketorininKinyukikanmeiKana = "1208",
            //                    uketorininKinyukikanmeiKanji = "1209",
            //                    uketorininShitenCode = 1210,
            //                    uketorininShitenmeiKana = "1211",
            //                    uketorininShitenmeiKanji = "1212",
            //                    uketorininKamokuCode = 1213,
            //                    uketorininKamokumei = "1214",
            //                    uketorininKozabango = 1215,
            //                    uketorininKanaShimei ="1216",
            //                },

            //            },
            //        },
                },
            };

            actual.Is(expected, new JsonComparer());
        }

        private IEnumerable<string> GetCsvStrings()
        {
            // ヘッダ部
            yield return "FileId,shoribi,shoriJikoku,hurikomiJisshiKahi,shokaiKekkaChikanKubun,kozaKakuninTRXID,uketorininKinyukikanCode,uketorininKinyukikanmeiKana,uketorininKinyukikanmeiKanji,uketorininShitenCode,uketorininShitenmeiKana,uketorininShitenmeiKanji,uketorininKamokuCode,uketorininKamokumei,uketorininKozabango,uketorininKanaShimei";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016";
            //yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113,1114,1115,1116";
            //yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213,1214,1215,1216";
        }
    }
}