using BankVision.WebAPI.Models.GW0013;
using BankVision.WebAPI.Models.GW0013.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0013RequestCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0013RequestCsvParser();

            var csv = new StringBuilder();
            foreach (string line in GetCsvStrings())
            {
                csv.AppendLine(line);
            }

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv.ToString()));
            var actual = target.Parse(stream);

            var expected = new List<Root<RequestMessageData>>()
            {
                new Root<RequestMessageData>()
                {
                    FileId = 1001,
                    Data = new RequestMessageData()
                    {
                        GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                        {
                            YokyuJoho = new YokyuJoho()
                            {
                                temban = 1002,
                                kamokuCode = 1003,
                                kozabango = 1004,
                                kaishibi = "1005",
                                shuryobi = "1006",
                            },
                            shokaiDaikoShokaiHyoji = 1007,
                            KurikaeshiSeigyo = new KurikaeshiSeigyo()
                            {
                                jiMeisaiariHyoji = 1008,
                                JiMeisaiKey = new JiMeisaiKey()
                                {
                                    tsugiSequence = "1009",
                                    bunrikichoKubun = 1010,
                                    hikitsugiZandaka = 1011,
                                },
                                shokaizumiMeisaiKensu = 1012
                            },
                            KensaKomoku = new KensaKomoku()
                            {
                                keiyakushaId = 1013,
                            },
                        },
                    },
                },
                new Root<RequestMessageData>()
                {
                    FileId = 1101,
                    Data = new RequestMessageData()
                    {
                        GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                        {
                            YokyuJoho = new YokyuJoho()
                            {
                                temban = 1102,
                                kamokuCode = 1103,
                                kozabango = 1104,
                                kaishibi = "1105",
                                shuryobi = "1106",
                            },
                            shokaiDaikoShokaiHyoji = 1107,
                            KurikaeshiSeigyo = new KurikaeshiSeigyo()
                            {
                                jiMeisaiariHyoji = 1108,
                                JiMeisaiKey = new JiMeisaiKey()
                                {
                                    tsugiSequence = "1109",
                                    bunrikichoKubun = 1110,
                                    hikitsugiZandaka = 1111,
                                },
                                shokaizumiMeisaiKensu = 1112
                            },
                            KensaKomoku = new KensaKomoku()
                            {
                                keiyakushaId = 1113,
                            },
                        },
                    },
                },
                new Root<RequestMessageData>()
                {
                    FileId = 1201,
                    Data = new RequestMessageData()
                    {
                        GaikaYokinNyushukkinMeisaiShokai = new GaikaYokinNyushukkinMeisaiShokai()
                        {
                            YokyuJoho = new YokyuJoho()
                            {
                                temban = 1202,
                                kamokuCode = 1203,
                                kozabango = 1204,
                                kaishibi = "1205",
                                shuryobi = "1206",
                            },
                            shokaiDaikoShokaiHyoji = 1207,
                            KurikaeshiSeigyo = new KurikaeshiSeigyo()
                            {
                                jiMeisaiariHyoji = 1208,
                                JiMeisaiKey = new JiMeisaiKey()
                                {
                                    tsugiSequence = "1209",
                                    bunrikichoKubun = 1210,
                                    hikitsugiZandaka = 1211,
                                },
                                shokaizumiMeisaiKensu = 1212
                            },
                            KensaKomoku = new KensaKomoku()
                            {
                                keiyakushaId = 1213,
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
            yield return "FileId,temban,kamokuCode,kozabango,kaishibi,shuryobi,shokaiDaikoShokaiHyoji,jiMeisaiariHyoji,tsugiSequence,bunrikichoKubun,hikitsugiZandaka,shokaizumiMeisaiKensu,keiyakushaId";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013";
            yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113";
            yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213";
        }
    }
}
