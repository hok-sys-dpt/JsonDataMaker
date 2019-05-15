using BankVision.WebAPI.Models.GW0008.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0008ResponseCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0008ResponseCsvParser();

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
                    FileId = 1001,
                    Data = new ResponseMessageData()
                    {
                        YokinkozaZandakashokai = new YokinkozaZandakashokai()
                        {
                            shoribi = "1002",
                            shoriJikoku = "1003",
                            ShokaiKozaJoho = new ShokaiKozaJoho()
                            {
                                temban = 1004,
                                tenmeiKana = "1005",
                                tenmeiKanji = "1006",
                                kamokuCode = 1007,
                                kamokumeiKanji = "1008",
                                kozabango = 1009,
                                cifBango = 1010,
                                kozameigiKana = "1011",
                                kozameigiKanji = "1012",
                            },
                            ZandakaJoho = new ZandakaJoho()
                            {
                                kozaZandaka = 1013,
                                shiharaikanoZandaka = 1014,
                                zenjitsuZandaka = 1015,
                                zengetsumatsuZandaka = 1016,
                                zenzengetsumatsuZandaka = 1017,
                                zenzenzengetsumatsuZandaka = 1018,
                            },
                            VisadebitPointJoho = new VisadebitPointJoho()
                            {
                                visadebitUmu = 1019,
                                pointZandaka = 1020,
                                shikkoYoteibi = "1021",
                                shikkoPoint = 1022,
                            },
                        },
                    },
                },
                new Root<ResponseMessageData>()
                {
                    FileId = 1101,
                    Data = new ResponseMessageData()
                    {
                        YokinkozaZandakashokai = new YokinkozaZandakashokai()
                        {
                            shoribi = "1102",
                            shoriJikoku = "1103",
                            ShokaiKozaJoho = new ShokaiKozaJoho()
                            {
                                temban = 1104,
                                tenmeiKana = "1105",
                                tenmeiKanji = "1106",
                                kamokuCode = 1107,
                                kamokumeiKanji = "1108",
                                kozabango = 1109,
                                cifBango = 1110,
                                kozameigiKana = "1111",
                                kozameigiKanji = "1112",
                            },
                            ZandakaJoho = new ZandakaJoho()
                            {
                                kozaZandaka = 1113,
                                shiharaikanoZandaka = 1114,
                                zenjitsuZandaka = 1115,
                                zengetsumatsuZandaka = 1116,
                                zenzengetsumatsuZandaka = 1117,
                                zenzenzengetsumatsuZandaka = 1118,
                            },
                            VisadebitPointJoho = new VisadebitPointJoho()
                            {
                                visadebitUmu = 1119,
                                pointZandaka = 1120,
                                shikkoYoteibi = "1121",
                                shikkoPoint = 1122,
                            },
                        },
                    },
                },
                new Root<ResponseMessageData>()
                {
                    FileId = 1201,
                    Data = new ResponseMessageData()
                    {
                        YokinkozaZandakashokai = new YokinkozaZandakashokai()
                        {
                            shoribi = "1202",
                            shoriJikoku = "1203",
                            ShokaiKozaJoho = new ShokaiKozaJoho()
                            {
                                temban = 1204,
                                tenmeiKana = "1205",
                                tenmeiKanji = "1206",
                                kamokuCode = 1207,
                                kamokumeiKanji = "1208",
                                kozabango = 1209,
                                cifBango = 1210,
                                kozameigiKana = "1211",
                                kozameigiKanji = "1212",
                            },
                            ZandakaJoho = new ZandakaJoho()
                            {
                                kozaZandaka = 1213,
                                shiharaikanoZandaka = 1214,
                                zenjitsuZandaka = 1215,
                                zengetsumatsuZandaka = 1216,
                                zenzengetsumatsuZandaka = 1217,
                                zenzenzengetsumatsuZandaka = 1218,
                            },
                            VisadebitPointJoho = new VisadebitPointJoho()
                            {
                                visadebitUmu = 1219,
                                pointZandaka = 1220,
                                shikkoYoteibi = "1221",
                                shikkoPoint = 1222,
                            },
                        },
                    },
                },
            };

            actual.Is(expected, new JsonComparer());
        }

        private IEnumerable<string> GetCsvStrings()
        {
            // ヘッダ部
            yield return "FileId,shoribi,shoriJikoku,temban,tenmeiKana,tenmeiKanji,kamokuCode,kamokumeiKanji,kozabango,cifBango,kozameigiKana,kozameigiKanji,kozaZandaka,shiharaikanoZandaka,zenjitsuZandaka,zengetsumatsuZandaka,zenzengetsumatsuZandaka,zenzenzengetsumatsuZandaka,visadebitUmu,pointZandaka,shikkoYoteibi,shikkoPoint";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016,1017,1018,1019,1020,1021,1022";
            yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113,1114,1115,1116,1117,1118,1119,1120,1121,1122";
            yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213,1214,1215,1216,1217,1218,1219,1220,1221,1222";
        }
    }
}
