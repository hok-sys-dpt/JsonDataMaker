using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.Maps;
using Newtonsoft.Json;

namespace JsonDataMaker.Core.Parsers
{
    public class NestedSampleCsvPaeser : ICsvParser<ParentSampleObject>
    {
        public IEnumerable<ParentSampleObject> Parse(Stream stream)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<ParentSampleObject> Parse(params Stream[] streams)
        {
            if (streams.Length != 2) { throw new ArgumentException(nameof(streams)); }

            var parentParser = new CsvParser<ParentSampleObject, ParentSampleMap>();
            var parents = parentParser.Parse(streams[0]);

            var childParser = new CsvParser<ChildSampleObject, ChildSampleMap>();
            var children = childParser.Parse(streams[1]);

            foreach (var item in parents)
            {
                item.Children = JsonConvert.DeserializeObject<IEnumerable<ChildSampleObject>>(JsonConvert.SerializeObject(children));
            }
            return parents;
        }
    }
}
