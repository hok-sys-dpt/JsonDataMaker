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
                                shohinShubetsu = 1005,
                                shohinMeisho = "1006",
                                nyukinKozaTemban = 1007,
                                nyukinKozaTenmei = "1008",
                                nyukinKozaTenmeiKana = "1009",
                                nyukinKozaKamokuCode = 1010,
                                nyukinKozaKamokumei = "1011",
                                nyukinKozabango = 1012,
                                teikiTemban = 1013,
                                teikiTenmei = "1014",
                                teikiTenmeiKana = "1015",
                                teikiKamokuCode = 1016,
                                teikiKamokuCodechiwake = 1017,
                                teikiKamokumei = "1018",
                                teikiKozabango = 1019,
                                yonyuKikan = 1020,
                                yonyuKikanMongon = "1021",
                                mankibi = "1022",
                                riritsu = 1023,
                                keizokuKubun = 1024,
                                keizokuKubunMeisho = "1025",
                                kazeiKubun = 1026,
                                kazeiKubunMeisho = "1027",
                                uketsukeKingaku = 1028,
                                risoku = 1029,
                                sashihikiShiharaiKingaku = 1030,
                                zeiGokei = 1031,
                                uchiKokuzei = 1032,
                                uchiChihozei = 1033,
                                teikiyokinHurikaeKingaku = 1034,
                                shiteiKozaFurikaeKingaku = 1035,
                                shiharaibi = "1036",
                                gankin = 1037,
                                yonyuBango = 1038,
                                kakuninJikkoKubun = 1039,
                                keiyakushaId = 1040,
                                meisaiBango = 1041
                            },
                        },
                    },
                },
                new Root<ResponseMessageData>()
                {
                    FileId = 1101,
                    Data = new ResponseMessageData()
                    {
                        Teikiyokinshiharai = new Teikiyokinshiharai()
                        {
                            IbTeikiShohinKaiyakuOto = new IbTeikiShohinKaiyakuOto()
                            {
                                shoribi = "1102",
                                shoriJikoku = "1103",
                                yonyubi = "1104",
                                shohinShubetsu = 1105,
                                shohinMeisho = "1106",
                                nyukinKozaTemban = 1107,
                                nyukinKozaTenmei = "1108",
                                nyukinKozaTenmeiKana = "1109",
                                nyukinKozaKamokuCode = 1110,
                                nyukinKozaKamokumei = "1111",
                                nyukinKozabango = 1112,
                                teikiTemban = 1113,
                                teikiTenmei = "1114",
                                teikiTenmeiKana = "1115",
                                teikiKamokuCode = 1116,
                                teikiKamokuCodechiwake = 1117,
                                teikiKamokumei = "1118",
                                teikiKozabango = 1119,
                                yonyuKikan = 1120,
                                yonyuKikanMongon = "1121",
                                mankibi = "1122",
                                riritsu = 1123,
                                keizokuKubun = 1124,
                                keizokuKubunMeisho = "1125",
                                kazeiKubun = 1126,
                                kazeiKubunMeisho = "1127",
                                uketsukeKingaku = 1128,
                                risoku = 1129,
                                sashihikiShiharaiKingaku = 1130,
                                zeiGokei = 1131,
                                uchiKokuzei = 1132,
                                uchiChihozei = 1133,
                                teikiyokinHurikaeKingaku = 1134,
                                shiteiKozaFurikaeKingaku = 1135,
                                shiharaibi = "1136",
                                gankin = 1137,
                                yonyuBango = 1138,
                                kakuninJikkoKubun = 1139,
                                keiyakushaId = 1140,
                                meisaiBango = 1141
                            },
                        },
                    },
                },
                new Root<ResponseMessageData>()
                {
                    FileId = 1201,
                    Data = new ResponseMessageData()
                    {
                        Teikiyokinshiharai = new Teikiyokinshiharai()
                        {
                            IbTeikiShohinKaiyakuOto = new IbTeikiShohinKaiyakuOto()
                            {
                                shoribi = "1202",
                                shoriJikoku = "1203",
                                yonyubi = "1204",
                                shohinShubetsu = 1205,
                                shohinMeisho = "1206",
                                nyukinKozaTemban = 1207,
                                nyukinKozaTenmei = "1208",
                                nyukinKozaTenmeiKana = "1209",
                                nyukinKozaKamokuCode = 1210,
                                nyukinKozaKamokumei = "1211",
                                nyukinKozabango = 1212,
                                teikiTemban = 1213,
                                teikiTenmei = "1214",
                                teikiTenmeiKana = "1215",
                                teikiKamokuCode = 1216,
                                teikiKamokuCodechiwake = 1217,
                                teikiKamokumei = "1218",
                                teikiKozabango = 1219,
                                yonyuKikan = 1220,
                                yonyuKikanMongon = "1221",
                                mankibi = "1222",
                                riritsu = 1223,
                                keizokuKubun = 1224,
                                keizokuKubunMeisho = "1225",
                                kazeiKubun = 1226,
                                kazeiKubunMeisho = "1227",
                                uketsukeKingaku = 1228,
                                risoku = 1229,
                                sashihikiShiharaiKingaku = 1230,
                                zeiGokei = 1231,
                                uchiKokuzei = 1232,
                                uchiChihozei = 1233,
                                teikiyokinHurikaeKingaku = 1234,
                                shiteiKozaFurikaeKingaku = 1235,
                                shiharaibi = "1236",
                                gankin = 1237,
                                yonyuBango = 1238,
                                kakuninJikkoKubun = 1239,
                                keiyakushaId = 1240,
                                meisaiBango = 1241
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
            yield return "FileId,shoribi,shoriJikoku,yonyubi,shohinShubetsu,shohinMeisho,nyukinKozaTemban,nyukinKozaTenmei,nyukinKozaTenmeiKana,nyukinKozaKamokuCode,nyukinKozaKamokumei,nyukinKozabango,teikiTemban,teikiTenmei,teikiTenmeiKana,teikiKamokuCode,teikiKamokuCodechiwake,teikiKamokumei,teikiKozabango,yonyuKikan,yonyuKikanMongon,mankibi,riritsu,keizokuKubun,keizokuKubunMeisho,kazeiKubun,kazeiKubunMeisho,uketsukeKingaku,risoku,sashihikiShiharaiKingaku,zeiGokei,uchiKokuzei,uchiChihozei,teikiyokinHurikaeKingaku,shiteiKozaFurikaeKingaku,shiharaibi,gankin,yonyuBango,kakuninJikkoKubun,keiyakushaId,meisaiBango";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016,1017,1018,1019,1020,1021,1022,1023,1024,1025,1026,1027,1028,1029,1030,1031,1032,1033,1034,1035,1036,1037,1038,1039,1040,1041";
            yield return "1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111,1112,1113,1114,1115,1116,1117,1118,1119,1120,1121,1122,1123,1124,1125,1126,1127,1128,1129,1130,1131,1132,1133,1134,1135,1136,1137,1138,1139,1140,1141";
            yield return "1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211,1212,1213,1214,1215,1216,1217,1218,1219,1220,1221,1222,1223,1224,1225,1226,1227,1228,1229,1230,1231,1232,1233,1234,1235,1236,1237,1238,1239,1240,1241";
        }
    }
}