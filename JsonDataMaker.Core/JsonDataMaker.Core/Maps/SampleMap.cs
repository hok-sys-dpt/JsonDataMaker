using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class SampleMap : ClassMap<Root<Sample>>
    {
        public SampleMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.FieldA).Index(1).Name("FieldA");
            Map(x => x.Data.FieldB).Index(2).Name("FieldB");
            Map(x => x.Data.FieldC).Ignore();
            Map(x => x.Data.FieldD).Index(3).Name("FieldD");
            Map(x => x.Data.FieldE).Index(4).Name("FieldE");
        }
    }
}
