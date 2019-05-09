using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;

namespace JsonDataMaker.Core.Maps
{
    public class ParentSampleMap : ClassMap<ParentSampleObject>
    {
        public ParentSampleMap()
        {
            Map(x => x.ParentA).Index(0).Name("ParentA");
            Map(x => x.ParentB).Index(1).Name("ParentB");
            Map(x => x.ParentC).Index(2).Name("ParentC");
            Map(x => x.ParentD).Index(3).Name("ParentD");
            Map(x => x.ParentE).Index(4).Name("ParentE");
            Map(x => x.Children).Ignore();
        }
    }

    public class ChildSampleMap : ClassMap<ChildSampleObject>
    {
        public ChildSampleMap()
        {
            Map(x => x.ChildA).Index(0).Name("ChildA");
            Map(x => x.ChildB).Index(1).Name("ChildB");
            Map(x => x.ChildC).Index(2).Name("ChildC");
            Map(x => x.ChildD).Index(3).Name("ChildD");
            Map(x => x.ChildE).Index(4).Name("ChildE");
        }
    }
}
