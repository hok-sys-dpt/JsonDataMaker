using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class ParentSampleMap : ClassMap<Root<ParentSample>>
    {
        public ParentSampleMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.ParentA).Index(0).Name("ParentA");
            Map(x => x.Data.ParentB).Index(1).Name("ParentB");
            Map(x => x.Data.ParentC).Index(2).Name("ParentC");
            Map(x => x.Data.ParentD).Index(3).Name("ParentD");
            Map(x => x.Data.ParentE).Index(4).Name("ParentE");
            Map(x => x.Data.Children).Ignore();
        }
    }

    public class ChildSampleMap : ClassMap<ChildSample>
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
