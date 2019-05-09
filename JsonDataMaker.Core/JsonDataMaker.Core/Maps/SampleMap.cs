using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;

namespace JsonDataMaker.Core.Maps
{
    public class SampleMap : ClassMap<SampleObject>
    {
        public SampleMap()
        {
            Map(x => x.FieldA).Index(0).Name("FieldA");
            Map(x => x.FieldB).Index(1).Name("FieldB");
            Map(x => x.FieldC).Ignore();
            Map(x => x.FieldD).Index(2).Name("FieldC");
            Map(x => x.FieldE).Index(3).Name("FieldD");
        }
    }
}
