using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace JsonDataMaker.Core.Parsers
{
    public class CsvParser<T, M> : ICsvParser<T>
        where M : ClassMap<T>
    {
        public IEnumerable<T> Parse(Stream stream)
        {
            return OnParse(stream);
        }


        public IEnumerable<T> Parse(params Stream[] streams)
        {
            return OnParse(streams);
        }

        protected virtual IEnumerable<T> OnParse(params Stream[] streams)
        {
            if (streams.Length != 1) { throw new ArgumentException(nameof(streams)); }

            using (var reader = new StreamReader(streams[0]))
            using (var csvReader = new CsvReader(reader))
            {
                csvReader.Configuration.RegisterClassMap<M>();
                return (csvReader.GetRecords<T>().ToArray());
            }
        }
    }
}
