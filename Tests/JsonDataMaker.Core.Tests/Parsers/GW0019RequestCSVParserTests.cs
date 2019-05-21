using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BankVision.WebAPI.Models.GW0019.Request;
using JsonDataMaker.Core.Parsers;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0019RequestCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0019RequestCsvParser();

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
                    HurikomisakiKozaShokai = new HurikomisakiKozaShokai()
                    {
                        HurikomisakiKozaShokaiYokyu = new HurikomisakiKozaShokaiYokyu()
                        {
                            torihikiYokyuKubun =1002,
                            IraininJoho = new IraininJoho()
                            {
                                iraininTemban = 1003,
                                iraininKamokuCode = 1004,
                                iraininKozabango = 1005,
                            },
                            UketorininJoho = new UketorininJoho()
                            {
                                uketorininKinyukikanCode = 1006,
                                uketorininKinyukikanmeiKana = "1007",
                                uketorininShitenCode = 1008,
                                uketorininShitenmeiKana = "1009",
                                uketorininKamokuCode = 1010,
                                uketorininKozabango = 1011,
                                uketorininKanaShimei = "1012",
                            },

                        },
                        KensaKomoku = new KensaKomoku()
                        {
                            keiyakushaId = 1013,
                        },
                    },
                },
                new RequestMessageData()
                {
                    HurikomisakiKozaShokai = new HurikomisakiKozaShokai()
                    {
                        HurikomisakiKozaShokaiYokyu = new HurikomisakiKozaShokaiYokyu()
                        {
                            torihikiYokyuKubun =1102,
                            IraininJoho = new IraininJoho()
                            {
                                iraininTemban = 1103,
                                iraininKamokuCode = 1104,
                                iraininKozabango = 1105,
                            },
                            UketorininJoho = new UketorininJoho()
                            {
                                uketorininKinyukikanCode = 1106,
                                uketorininKinyukikanmeiKana = "1107",
                                uketorininShitenCode = 1108,
                                uketorininShitenmeiKana = "1109",
                                uketorininKamokuCode = 1110,
                                uketorininKozabango = 1111,
                                uketorininKanaShimei = "1112",
                            },

                        },
                        KensaKomoku = new KensaKomoku()
                        {
                            keiyakushaId = 1113,
                        },
                    },
                },
                new RequestMessageData()
                {
                    HurikomisakiKozaShokai = new HurikomisakiKozaShokai()
                    {
                        HurikomisakiKozaShokaiYokyu = new HurikomisakiKozaShokaiYokyu()
                        {
                            torihikiYokyuKubun =1202,
                            IraininJoho = new IraininJoho()
                            {
                                iraininTemban = 1203,
                                iraininKamokuCode = 1204,
                                iraininKozabango = 1205,
                            },
                            UketorininJoho = new UketorininJoho()
                            {
                                uketorininKinyukikanCode = 1206,
                                uketorininKinyukikanmeiKana = "1207",
                                uketorininShitenCode = 1208,
                                uketorininShitenmeiKana = "1209",
                                uketorininKamokuCode = 1210,
                                uketorininKozabango = 1211,
                                uketorininKanaShimei = "1212",
                            },

                        },
                        KensaKomoku = new KensaKomoku()
                        {
                            keiyakushaId = 1213,
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