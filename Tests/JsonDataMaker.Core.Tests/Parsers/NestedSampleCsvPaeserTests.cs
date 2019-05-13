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
    public class NestedSampleCsvPaeserTests
    {
        [Theory]
        [MemberData(nameof(ParseTestSource))]
        public void Parse(string parentCsv, string childCsv, IEnumerable<Root<ParentSample>> expected)
        {
            var target = new NestedSampleCsvPaeser();
            using (var parentStream = new MemoryStream(Encoding.UTF8.GetBytes(parentCsv.ToString())))
            using (var childStream = new MemoryStream(Encoding.UTF8.GetBytes(childCsv.ToString())))
            {
                var actual = target.Parse(parentStream, childStream);
                actual.Is(expected, new JsonComparer());
            }
        }


        public static IEnumerable<object[]> ParseTestSource
        {
            get
            {
                {
                    var parentCsv = new StringBuilder();
                    parentCsv.AppendLine("FileId,ParentA,ParentB,ParentC,ParentD,ParentE");
                    parentCsv.AppendLine("1,A1,B1,C1,D1,E1");
                    parentCsv.AppendLine("2,A2,B2,C2,D2,E2");
                    parentCsv.AppendLine("3,A3,B3,C3,D3,E3");

                    var childCsv = new StringBuilder();
                    childCsv.AppendLine("ChildA,ChildB,ChildC,ChildD,ChildE");
                    childCsv.AppendLine("c_A1,c_B1,c_C1,c_D1,c_E1");
                    childCsv.AppendLine("c_A2,c_B2,c_C2,c_D2,c_E2");
                    childCsv.AppendLine("c_A3,c_B3,c_C3,c_D3,c_E3");
                    childCsv.AppendLine("c_A4,c_B4,c_C4,c_D4,c_E4");
                    childCsv.AppendLine("c_A5,c_B5,c_C5,c_D5,c_E5");

                    var expected = new List<Root<ParentSample>>()
                    {
                        new Root<ParentSample>(){ FileId = 1, Data =  new ParentSample(){ ParentA = "A1", ParentB = "B1", ParentC = "C1", ParentD = "D1", ParentE = "E1" }},
                        new Root<ParentSample>(){ FileId = 2, Data =  new ParentSample(){ ParentA = "A2", ParentB = "B2", ParentC = "C2", ParentD = "D2", ParentE = "E2" }},
                        new Root<ParentSample>(){ FileId = 3, Data =  new ParentSample(){ ParentA = "A3", ParentB = "B3", ParentC = "C3", ParentD = "D3", ParentE = "E3" }},
                    };
                    foreach (var item in expected)
                    {
                        item.Data.Children = new List<ChildSample>()
                        {
                            new ChildSample(){ ChildA = "c_A1", ChildB = "c_B1", ChildC = "c_C1", ChildD = "c_D1", ChildE = "c_E1" },
                            new ChildSample(){ ChildA = "c_A2", ChildB = "c_B2", ChildC = "c_C2", ChildD = "c_D2", ChildE = "c_E2" },
                            new ChildSample(){ ChildA = "c_A3", ChildB = "c_B3", ChildC = "c_C3", ChildD = "c_D3", ChildE = "c_E3" },
                            new ChildSample(){ ChildA = "c_A4", ChildB = "c_B4", ChildC = "c_C4", ChildD = "c_D4", ChildE = "c_E4" },
                            new ChildSample(){ ChildA = "c_A5", ChildB = "c_B5", ChildC = "c_C5", ChildD = "c_D5", ChildE = "c_E5" },
                        };
                    }
                    yield return new object[] { parentCsv.ToString(), childCsv.ToString(), expected };
                }

                {
                    var parentCsv = new StringBuilder();
                    parentCsv.AppendLine("FileId,ParentA,ParentB,ParentC,ParentD,ParentE");
                    parentCsv.AppendLine("4,A1,B1,C1,D1,E1");
                    parentCsv.AppendLine("5,A2,B2,C2,D2,E2");
                    parentCsv.AppendLine("6,A3,B3,C3,D3,E3");

                    var childCsv = new StringBuilder();
                    childCsv.AppendLine("ChildA,ChildB,ChildC,ChildD,ChildE");
                    childCsv.AppendLine("c_A1,c_B1,c_C1,c_D1,c_E1");
                    childCsv.AppendLine("c_A2,c_B2,c_C2,c_D2,c_E2");
                    childCsv.AppendLine("c_A3,c_B3,c_C3,c_D3,c_E3");
                    childCsv.AppendLine("c_A4,c_B4,c_C4,c_D4,c_E4");
                    childCsv.AppendLine("c_A5,c_B5,c_C5,c_D5,c_E5");

                    var expected = new List<Root<ParentSample>>()
                    {
                        new Root<ParentSample>(){ FileId = 4, Data =  new ParentSample(){ ParentA = "A1", ParentB = "B1", ParentC = "C1", ParentD = "D1", ParentE = "E1" }},
                        new Root<ParentSample>(){ FileId = 5, Data =  new ParentSample(){ ParentA = "A2", ParentB = "B2", ParentC = "C2", ParentD = "D2", ParentE = "E2" }},
                        new Root<ParentSample>(){ FileId = 6, Data =  new ParentSample(){ ParentA = "A3", ParentB = "B3", ParentC = "C3", ParentD = "D3", ParentE = "E3" }},
                    };
                    foreach (var item in expected)
                    {
                        item.Data.Children = new List<ChildSample>()
                        {
                            new ChildSample(){ ChildA = "c_A1", ChildB = "c_B1", ChildC = "c_C1", ChildD = "c_D1", ChildE = "c_E1" },
                            new ChildSample(){ ChildA = "c_A2", ChildB = "c_B2", ChildC = "c_C2", ChildD = "c_D2", ChildE = "c_E2" },
                            new ChildSample(){ ChildA = "c_A3", ChildB = "c_B3", ChildC = "c_C3", ChildD = "c_D3", ChildE = "c_E3" },
                            new ChildSample(){ ChildA = "c_A4", ChildB = "c_B4", ChildC = "c_C4", ChildD = "c_D4", ChildE = "c_E4" },
                            new ChildSample(){ ChildA = "c_A5", ChildB = "c_B5", ChildC = "c_C5", ChildD = "c_D5", ChildE = "c_E5" },
                        };
                    }
                    yield return new object[] { parentCsv.ToString(), childCsv.ToString(), expected };
                }
            }
        }
    }
}
