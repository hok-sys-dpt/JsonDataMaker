using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BankVision.WebAPI.Models.GW0020.Request;
using JsonDataMaker.Core.Parsers;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0020RequestCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0020RequestCsvParser();

            var csv = new StringBuilder();
            foreach (string line in GetCsvStrings())
            {
                csv.AppendLine(line);
            }

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv.ToString()));
            var actual = target.Parse(stream);

            var expected = new List<RequestMessageData>()
            {
                new RequestMessageData()
                {
                    HurikomiJikko = new HurikomiJikko()
                    {
                        HurikomiJikkoYokyu = new HurikomiJikkoYokyu()
                        {
                            kakuninJikkoKubun = 1002,
                            hurikomiShiteibi = "1003",
                            hurikomiKingaku = 1004,
                            tesuryoSashihikiHyoji = 1005,
                            tesuryokonoHyoji = 1006,
                            hurikomisakitorokuyoHyoji = 1007,
                            uketorininShiteiKubun = 1008,
                            uketorininTenyuryokuHyoji = 1009,
                            kakuninjiTesuryoKingaku = 1010,
                            chokkinkozakakuninTRXID = "1011",
                            torokuBango = 1012,

                            IraininJoho = new IraininJoho{
                                iraininTemban = 1013,
                                iraininKamokuCode = 1014,
                                iraininKozabango = 1015,
                                iraininmeiKana = "1016",
                            },
                            UketorininJoho = new UketorininJoho
                            {
                                uketorininKinyukikanCode=1017,
                                uketorininKinyukikanmeiKana="1018",
                                uketorininShitenCode=1019,
                                uketorininShitenmeiKana="1020",
                                uketorininKamokuCode = 1021,
                                uketorininKozabango=1022,
                                uketorininmeiKana="1023",
                            },
                        },
                        KensaKomoku = new KensaKomoku()
                        {
                            keiyakushaId = 1024
                        },
                     },
                },
                new RequestMessageData()
                {
                    HurikomiJikko = new HurikomiJikko()
                    {
                        HurikomiJikkoYokyu = new HurikomiJikkoYokyu()
                        {
                            kakuninJikkoKubun = 1002,
                            hurikomiShiteibi = "1003",
                            hurikomiKingaku = 1004,
                            tesuryoSashihikiHyoji = 1005,
                            tesuryokonoHyoji = 1006,
                            hurikomisakitorokuyoHyoji = 1007,
                            uketorininShiteiKubun = 1008,
                            uketorininTenyuryokuHyoji = 1009,
                            kakuninjiTesuryoKingaku = 1010,
                            chokkinkozakakuninTRXID = "1011",
                            torokuBango = 1012,

                            IraininJoho = new IraininJoho{
                                iraininTemban = 1013,
                                iraininKamokuCode = 1014,
                                iraininKozabango = 1015,
                                iraininmeiKana = "1016",
                            },
                            UketorininJoho = new UketorininJoho
                            {
                                uketorininKinyukikanCode=1017,
                                uketorininKinyukikanmeiKana="1018",
                                uketorininShitenCode=1019,
                                uketorininShitenmeiKana="1020",
                                uketorininKamokuCode = 1021,
                                uketorininKozabango=1022,
                                uketorininmeiKana="1023",
                            },
                        },
                        KensaKomoku = new KensaKomoku()
                        {
                            keiyakushaId = 1024
                        },
                    },
                },
                new RequestMessageData()
                {
                    HurikomiJikko = new HurikomiJikko()
                    {
                        HurikomiJikkoYokyu = new HurikomiJikkoYokyu()
                        {
                            kakuninJikkoKubun = 1002,
                            hurikomiShiteibi = "1003",
                            hurikomiKingaku = 1004,
                            tesuryoSashihikiHyoji = 1005,
                            tesuryokonoHyoji = 1006,
                            hurikomisakitorokuyoHyoji = 1007,
                            uketorininShiteiKubun = 1008,
                            uketorininTenyuryokuHyoji = 1009,
                            kakuninjiTesuryoKingaku = 1010,
                            chokkinkozakakuninTRXID = "1011",
                            torokuBango = 1012,

                            IraininJoho = new IraininJoho{
                                iraininTemban = 1013,
                                iraininKamokuCode = 1014,
                                iraininKozabango = 1015,
                                iraininmeiKana = "1016",
                            },
                            UketorininJoho = new UketorininJoho
                            {
                                uketorininKinyukikanCode=1017,
                                uketorininKinyukikanmeiKana="1018",
                                uketorininShitenCode=1019,
                                uketorininShitenmeiKana="1020",
                                uketorininKamokuCode = 1021,
                                uketorininKozabango=1022,
                                uketorininmeiKana="1023",
                            },
                        },
                        KensaKomoku = new KensaKomoku()
                        {
                            keiyakushaId = 1024
                        },
                     },
                },
            };
            actual.Is(expected, new JsonComparer());
        }

        private IEnumerable<string> GetCsvStrings()
        {
            // ヘッダ部
            yield return "FileId,torihikiYokyuKubun,iraininTemban,iraininKamokuCode,iraininKozabango,uketorininKinyukikanCode,uketorininKinyukikanmeiKana,uketorininShitenCode,uketorininShitenmeiKana,uketorininKamokuCode,uketorininKozabango,uketorininKanaShimei,keiyakushaId";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013";
            yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113";
            yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213";
        }
    }
}