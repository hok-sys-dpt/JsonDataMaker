using BankVision.WebAPI.Models.GW1001.Request;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW1001RequestCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW1001RequestCsvParser();

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
                    FileId = 0001,
                    Data = new RequestMessageData()
                    {
                        BizIbKeiyakushaJohoShokai = new BizIbKeiyakushaJohoShokai()
                        {
                            keiyakushaId = 8000019,
                            temban = 0,
                            kamokuCode = 0,
                            kozabango = 0,
                        },
                    },
                },
                new Root<RequestMessageData>()
                {
                    FileId = 0007,
                    Data = new RequestMessageData()
                    {
                        BizIbKeiyakushaJohoShokai = new BizIbKeiyakushaJohoShokai()
                        {
                            keiyakushaId = 0,
                            temban = 101,
                            kamokuCode = 2,
                            kozabango = 2001903,
                        },
                    },
                },
                new Root<RequestMessageData>()
                {
                    FileId = 1010,
                    Data = new RequestMessageData()
                    {
                        BizIbKeiyakushaJohoShokai = new BizIbKeiyakushaJohoShokai()
                        {
                            keiyakushaId = 0,
                            temban = 1,
                            kamokuCode = 1,
                            kozabango = 1,
                        },
                    },
                },
            };

            actual.Is(expected, new JsonComparer());
        }

        private IEnumerable<string> GetCsvStrings()
        {
            // ヘッダ部
            yield return "FileId,keiyakushaId,temban,kamokuCode,kozabango";
            // データ部
            yield return "0001,8000019,0,0,0";
            yield return "0007,0,101,2,2001903";
            yield return "0010,0,1,1,1";
        }
    }
}