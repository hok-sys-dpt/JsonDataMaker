using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;
using Newtonsoft.Json;

namespace JsonDataMaker.Core.Parsers
{
    public class NestedSampleCsvPaeser : ICsvParser<Root<ParentSample>>
    {
        public IEnumerable<Root<ParentSample>> Parse(Stream stream)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<Root<ParentSample>> Parse(params Stream[] streams)
        {
            if (streams.Length != 2) { throw new ArgumentException(nameof(streams)); }

            var parentParser = new CsvParser<Root<ParentSample>, ParentSampleMap>();
            var parents = parentParser.Parse(streams[0]);

            var childParser = new CsvParser<ChildSample, ChildSampleMap>();
            var children = childParser.Parse(streams[1]);

            foreach (var item in parents)
            {
                item.Data.Children = JsonConvert.DeserializeObject<IEnumerable<ChildSample>>(JsonConvert.SerializeObject(children));
            }
            return parents;
        }
    }
}
