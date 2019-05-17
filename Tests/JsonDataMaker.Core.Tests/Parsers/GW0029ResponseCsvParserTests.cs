using BankVision.WebAPI.Models.GW0029.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0029ResponseCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0029ResponseCsvParser();

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
                        Teikiyokinshiharai = new Teikiyokinshiharai()
                        {
                            IbTeikiShohinKaiyakuOto = new IbTeikiShohinKaiyakuOto()
                            {
                                shoribi = "1002",
                                shoriJikoku = "1003",
                                yonyubi = "1004",
                                shohinShubetsu = "1005",
                                shohinMeisho = "1006",
                                nyukinKozaTemban = "1007",
                                nyukinKozaTenmei = "1008",
                                nyukinKozaTenmeiKana = "1009",
                                nyukinKozaKamokuCode = "1010",
                                nyukinKozaKamokumei = "1011",
                                nyukinKozabango = "1012",
                                teikiTemban = "1013",
                                teikiTenmei = "1014",
                                teikiTenmeiKana = "1015",
                                teikiKamokuCode = "1016",
                                teikiKamokuCodechiwake = "1017",
                                teikiKamokumei = "1018",
                                teikiKozabango = "1019",
                                yonyuKikan = "1020",
                                yonyuKikanMongon = "1021",
                                mankibi = "1022",
                                riritsu = "1023",
                                keizokuKubun = "1024",
                                keizokuKubunMeisho = "1025",
                                kazeiKubun = "1026",
                                kazeiKubunMeisho = "1027",
                                uketsukeKingaku = "1028",
                                risoku = "1029",
                                sashihikiShiharaiKingaku = "1030",
                                zeiGokei = "1031",
                                uchiKokuzei = "1032",
                                uchiChihozei = "1033",
                                teikiyokinHurikaeKingaku = "1034",
                                shiteiKozaFurikaeKingaku = "1035",
                                shiharaibi = "1036",
                                gankin = "1037",
                                yonyuBango = "1038",
                                kakuninJikkoKubun = "1039",
                                keiyakushaId = "1040",
                                meisaiBango = "1041"
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
            yield return "shoribi,shoriJikoku,yonyubi,shohinShubetsu,shohinMeisho,nyukinKozaTemban,nyukinKozaTenmei,nyukinKozaTenmeiKana,nyukinKozaKamokuCode,nyukinKozaKamokumei,nyukinKozabango,teikiTemban,teikiTenmei,teikiTenmeiKana,teikiKamokuCode,teikiKamokuCodechiwake,teikiKamokumei,teikiKozabango,yonyuKikan,yonyuKikanMongon,mankibi,riritsu,keizokuKubun,keizokuKubunMeisho,kazeiKubunkazeiKubunMeisho,uketsukeKingaku,risoku,sashihikiShiharaiKingaku,zeiGokei,uchiKokuzei,uchiChihozei,teikiyokinHurikaeKingaku,shiteiKozaFurikaeKingaku,shiharaibi,gankin,yonyuBango,kakuninJikkoKubun,keiyakushaId,meisaiBango";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016,1017,1018,1019,1020,1021,1022";
            yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113,1114,1115,1116,1117,1118,1119,1120,1121,1122";
            yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213,1214,1215,1216,1217,1218,1219,1220,1221,1222";
        }
    }
}