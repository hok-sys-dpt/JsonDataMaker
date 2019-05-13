using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Parsers;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class SampleCsvPaeserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new SampleCsvPaeser();

            var csv = new StringBuilder();
            csv.AppendLine("FileId,FieldA,FieldB,FieldC,FieldD,FieldE");
            csv.AppendLine("1,A1,B1,C1,D1,E1");
            csv.AppendLine("2,A2,B2,C2,D2,E2");
            csv.AppendLine("3,A3,B3,C3,D3,E3");
            csv.AppendLine("4,A4,B4,C4,D4,E4");

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv.ToString()));
            var actual = target.Parse(stream);

            var expected = new List<Root<Sample>>()
            {
                new Root<Sample>(){ FileId = 1, Data =  new Sample(){ FieldA = "A1", FieldB = "B1", FieldC = null, FieldD = "D1", FieldE = "E1" }},
                new Root<Sample>(){ FileId = 2, Data =   new Sample(){ FieldA = "A2", FieldB = "B2", FieldC = null, FieldD = "D2", FieldE = "E2" }},
                new Root<Sample>(){ FileId = 3, Data = new Sample() { FieldA = "A3", FieldB = "B3", FieldC = null, FieldD = "D3", FieldE = "E3"  }},
                new Root<Sample>(){ FileId = 4, Data =  new Sample(){ FieldA = "A4", FieldB = "B4", FieldC = null, FieldD = "D4", FieldE = "E4" }},
            };

            actual.Is(expected, new JsonComparer());
        }
    }
}
