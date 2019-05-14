using BankVision.WebAPI.Models.GW0013;
using BankVision.WebAPI.Models.GW0013.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0013ResponseCsvParserTests
    {
        private static readonly MeisaiJoho DefaultMeisaiJoho = new MeisaiJoho()
        {
            sequence = String.Empty,
            torihikibi = String.Empty,
            torihikiJikoku = String.Empty,
            iriharaiKubun = 0,
            torihikiKingaku = Decimal.Zero,
            hyomenZandaka = Decimal.Zero,
            tsukaCode = String.Empty,
            tsukaMeisho = String.Empty,
            tekiyoKanji = String.Empty,
            tekiyoKana = String.Empty,
        };

        public static IEnumerable<object[]> ParseTestSource
        {
            get
            {
                {
                    var parentCsv = new StringBuilder();
                    foreach (string line in GetParentCsvStrings(1))
                    {
                        parentCsv.AppendLine(line);
                    }

                    var childCsv = new StringBuilder();
                    foreach (string line in GetChildCsvStrings(1))
                    {
                        childCsv.AppendLine(line);
                    }

                    var expected = new List<Root<ResponseMessageData>>()
                    {
                        new Root<ResponseMessageData>()
                        {
                            FileId = 1001,
                            Data = new ResponseMessageData()
                            {
                                GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                                {
                                    shoribi = "1002",
                                    shoriJikoku = "1003",
                                    KozaJoho = new KozaJoho()
                                    {
                                        temban = 1004,
                                        tenmeiKana = "1005",
                                        tenmeiKanji = "1006",
                                        kamokuCode = 1007,
                                        kamokumeiKanji = "1008",
                                        kozabango = 1009,
                                    },
                                    shokaiDaikoShokaiHyoji = 1010,
                                    KurikaeshiSeigyo = new KurikaeshiSeigyo()
                                    {
                                        jiMeisaiariHyoji = 1011,
                                        JiMeisaiKey = new JiMeisaiKey()
                                        {
                                            tsugiSequence = "1012",
                                            bunrikichoKubun = 1013,
                                            hikitsugiZandaka = 1014,
                                        },
                                        shokaizumiMeisaiKensu = 1015,
                                    },
                                    otoKensu = 1016,
                                },
                            },
                        },
                        new Root<ResponseMessageData>()
                        {
                            FileId = 1101,
                            Data = new ResponseMessageData()
                            {
                                GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                                {
                                    shoribi = "1102",
                                    shoriJikoku = "1103",
                                    KozaJoho = new KozaJoho()
                                    {
                                        temban = 1104,
                                        tenmeiKana = "1105",
                                        tenmeiKanji = "1106",
                                        kamokuCode = 1107,
                                        kamokumeiKanji = "1108",
                                        kozabango = 1109,
                                    },
                                    shokaiDaikoShokaiHyoji = 1110,
                                    KurikaeshiSeigyo = new KurikaeshiSeigyo()
                                    {
                                        jiMeisaiariHyoji = 1111,
                                        JiMeisaiKey = new JiMeisaiKey()
                                        {
                                            tsugiSequence = "1112",
                                            bunrikichoKubun = 1113,
                                            hikitsugiZandaka = 1114,
                                        },
                                        shokaizumiMeisaiKensu = 1115,
                                    },
                                    otoKensu = 1116,
                                },
                            },
                        },
                        new Root<ResponseMessageData>()
                        {
                            FileId = 1201,
                            Data = new ResponseMessageData()
                            {
                                GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                                {
                                    shoribi = "1202",
                                    shoriJikoku = "1203",
                                    KozaJoho = new KozaJoho()
                                    {
                                        temban = 1204,
                                        tenmeiKana = "1205",
                                        tenmeiKanji = "1206",
                                        kamokuCode = 1207,
                                        kamokumeiKanji = "1208",
                                        kozabango = 1209,
                                    },
                                    shokaiDaikoShokaiHyoji = 1210,
                                    KurikaeshiSeigyo = new KurikaeshiSeigyo()
                                    {
                                        jiMeisaiariHyoji = 1211,
                                        JiMeisaiKey = new JiMeisaiKey()
                                        {
                                            tsugiSequence = "1212",
                                            bunrikichoKubun = 1213,
                                            hikitsugiZandaka = 1214,
                                        },
                                        shokaizumiMeisaiKensu = 1215,
                                    },
                                    otoKensu = 1216,
                                },
                            },
                        },
                    };
                    foreach (var item in expected)
                    {
                        List<MeisaiJoho> meisaiJohos = new List<MeisaiJoho>()
                        {
                            new MeisaiJoho
                            {
                                sequence = "2001",
                                torihikibi = "2002",
                                torihikiJikoku = "2003",
                                iriharaiKubun = 2004,
                                torihikiKingaku = Convert.ToDecimal(20.05),
                                hyomenZandaka = Convert.ToDecimal(20.06),
                                tsukaCode = "2007",
                                tsukaMeisho = "2008",
                                tekiyoKanji = "2009",
                                tekiyoKana = "2010",
                            },
                            new MeisaiJoho
                            {
                                sequence = "2101",
                                torihikibi = "2102",
                                torihikiJikoku = "2103",
                                iriharaiKubun = 2104,
                                torihikiKingaku = Convert.ToDecimal(21.05),
                                hyomenZandaka = Convert.ToDecimal(21.06),
                                tsukaCode = "2107",
                                tsukaMeisho = "2108",
                                tekiyoKanji = "2109",
                                tekiyoKana = "2110",
                            },
                            new MeisaiJoho
                            {
                                sequence = "2201",
                                torihikibi = "2202",
                                torihikiJikoku = "2203",
                                iriharaiKubun = 2204,
                                torihikiKingaku = Convert.ToDecimal(22.05),
                                hyomenZandaka = Convert.ToDecimal(22.06),
                                tsukaCode = "2207",
                                tsukaMeisho = "2208",
                                tekiyoKanji = "2209",
                                tekiyoKana = "2210",
                            },
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                        };
                        item.Data.GaikaYokinNyushukkinMeisaiShokai.MeisaiJoho = meisaiJohos.ToArray();
                    }
                    yield return new object[] { parentCsv.ToString(), childCsv.ToString(), expected };
                }

                {
                    var parentCsv = new StringBuilder();
                    foreach (string line in GetParentCsvStrings(2))
                    {
                        parentCsv.AppendLine(line);
                    }

                    var childCsv = new StringBuilder();
                    foreach (string line in GetChildCsvStrings(1))
                    {
                        childCsv.AppendLine(line);
                    }

                    var expected = new List<Root<ResponseMessageData>>()
                    {
                        new Root<ResponseMessageData>()
                        {
                            FileId = 1301,
                            Data = new ResponseMessageData()
                            {
                                GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                                {
                                    shoribi = "1302",
                                    shoriJikoku = "1303",
                                    KozaJoho = new KozaJoho()
                                    {
                                        temban = 1304,
                                        tenmeiKana = "1305",
                                        tenmeiKanji = "1306",
                                        kamokuCode = 1307,
                                        kamokumeiKanji = "1308",
                                        kozabango = 1309,
                                    },
                                    shokaiDaikoShokaiHyoji = 1310,
                                    KurikaeshiSeigyo = new KurikaeshiSeigyo()
                                    {
                                        jiMeisaiariHyoji = 1311,
                                        JiMeisaiKey = new JiMeisaiKey()
                                        {
                                            tsugiSequence = "1312",
                                            bunrikichoKubun = 1313,
                                            hikitsugiZandaka = 1314,
                                        },
                                        shokaizumiMeisaiKensu = 1315,
                                    },
                                    otoKensu = 1316,
                                },
                            },
                        },
                        new Root<ResponseMessageData>()
                        {
                            FileId = 1401,
                            Data = new ResponseMessageData()
                            {
                                GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                                {
                                    shoribi = "1402",
                                    shoriJikoku = "1403",
                                    KozaJoho = new KozaJoho()
                                    {
                                        temban = 1404,
                                        tenmeiKana = "1405",
                                        tenmeiKanji = "1406",
                                        kamokuCode = 1407,
                                        kamokumeiKanji = "1408",
                                        kozabango = 1409,
                                    },
                                    shokaiDaikoShokaiHyoji = 1410,
                                    KurikaeshiSeigyo = new KurikaeshiSeigyo()
                                    {
                                        jiMeisaiariHyoji = 1411,
                                        JiMeisaiKey = new JiMeisaiKey()
                                        {
                                            tsugiSequence = "1412",
                                            bunrikichoKubun = 1413,
                                            hikitsugiZandaka = 1414,
                                        },
                                        shokaizumiMeisaiKensu = 1415,
                                    },
                                    otoKensu = 1416,
                                },
                            },
                        },
                        new Root<ResponseMessageData>()
                        {
                            FileId = 1501,
                            Data = new ResponseMessageData()
                            {
                                GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                                {
                                    shoribi = "1502",
                                    shoriJikoku = "1503",
                                    KozaJoho = new KozaJoho()
                                    {
                                        temban = 1504,
                                        tenmeiKana = "1505",
                                        tenmeiKanji = "1506",
                                        kamokuCode = 1507,
                                        kamokumeiKanji = "1508",
                                        kozabango = 1509,
                                    },
                                    shokaiDaikoShokaiHyoji = 1510,
                                    KurikaeshiSeigyo = new KurikaeshiSeigyo()
                                    {
                                        jiMeisaiariHyoji = 1511,
                                        JiMeisaiKey = new JiMeisaiKey()
                                        {
                                            tsugiSequence = "1512",
                                            bunrikichoKubun = 1513,
                                            hikitsugiZandaka = 1514,
                                        },
                                        shokaizumiMeisaiKensu = 1515,
                                    },
                                    otoKensu = 1516,
                                },
                            },
                        },
                    };
                    foreach (var item in expected)
                    {
                        List<MeisaiJoho> meisaiJohos = new List<MeisaiJoho>()
                        {
                            new MeisaiJoho
                            {
                                sequence = "2001",
                                torihikibi = "2002",
                                torihikiJikoku = "2003",
                                iriharaiKubun = 2004,
                                torihikiKingaku = Convert.ToDecimal(20.05),
                                hyomenZandaka = Convert.ToDecimal(20.06),
                                tsukaCode = "2007",
                                tsukaMeisho = "2008",
                                tekiyoKanji = "2009",
                                tekiyoKana = "2010",
                            },
                            new MeisaiJoho
                            {
                                sequence = "2101",
                                torihikibi = "2102",
                                torihikiJikoku = "2103",
                                iriharaiKubun = 2104,
                                torihikiKingaku = Convert.ToDecimal(21.05),
                                hyomenZandaka = Convert.ToDecimal(21.06),
                                tsukaCode = "2107",
                                tsukaMeisho = "2108",
                                tekiyoKanji = "2109",
                                tekiyoKana = "2110",
                            },
                            new MeisaiJoho
                            {
                                sequence = "2201",
                                torihikibi = "2202",
                                torihikiJikoku = "2203",
                                iriharaiKubun = 2204,
                                torihikiKingaku = Convert.ToDecimal(22.05),
                                hyomenZandaka = Convert.ToDecimal(22.06),
                                tsukaCode = "2207",
                                tsukaMeisho = "2208",
                                tekiyoKanji = "2209",
                                tekiyoKana = "2210",
                            },
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                            DefaultMeisaiJoho,
                        };
                        item.Data.GaikaYokinNyushukkinMeisaiShokai.MeisaiJoho = meisaiJohos.ToArray();
                    }
                    yield return new object[] { parentCsv.ToString(), childCsv.ToString(), expected };
                }
            }
        }

        [Theory]
        [MemberData(nameof(ParseTestSource))]
        public void Parse(string parentCsv, string childCsv, IEnumerable<Root<ResponseMessageData>> expected)
        {
            var target = new GW0013ResponseCsvParser();
            using (var parentStream = new MemoryStream(Encoding.UTF8.GetBytes(parentCsv.ToString())))
            using (var childStream = new MemoryStream(Encoding.UTF8.GetBytes(childCsv.ToString())))
            {
                var actual = target.Parse(parentStream, childStream);
                actual.Is(expected, new JsonComparer());
            }
        }

        private static IEnumerable<string> GetParentCsvStrings(int pattern)
        {
            // ヘッダ部
            yield return "FileId,shoribi,shoriJikoku,temban,tenmeiKana,tenmeiKanji,kamokuCode,kamokumeiKanji,kozabango,shokaiDaikoShokaiHyoji,jiMeisaiariHyoji,tsugiSequence,bunrikichoKubun,hikitsugiZandaka,shokaizumiMeisaiKensu,otoKensu";
            // データ部
            switch (pattern)
            {
                case 1:
                    yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016";
                    yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113,1114,1115,1116";
                    yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213,1214,1215,1216";
                    break;
                case 2:
                    yield return "1301,1302,1303,1304,1305,1306,1307,1308,1309,1310,1311,1312,1313,1314,1315,1316";
                    yield return "1401,1402,1403,1404,1405,1406,1407,1408,1409,1410,1411,1412,1413,1414,1415,1416";
                    yield return "1501,1502,1503,1504,1505,1506,1507,1508,1509,1510,1511,1512,1513,1514,1515,1516";
                    break;
            }
        }

        private static IEnumerable<string> GetChildCsvStrings(int pattern)
        {
            // ヘッダ部
            yield return "sequence,torihikibi,torihikiJikoku,iriharaiKubun,torihikiKingaku,hyomenZandaka,tsukaCode,tsukaMeisho,tekiyoKanji,tekiyoKana";
            // データ部
            switch (pattern)
            {
                case 1:
                    yield return "2001,2002,2003,2004,20.05,20.06,2007,2008,2009,2010";
                    yield return "2101,2102,2103,2104,21.05,21.06,2107,2108,2109,2110";
                    yield return "2201,2202,2203,2204,22.05,22.06,2207,2208,2209,2210";
                    break;
            }
        }
    }
}
