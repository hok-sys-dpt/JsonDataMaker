using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace JsonDataMaker.Core.Parsers
{
    public class CsvParser<T, M> : ICsvParser
        where M : ClassMap<T>
    {
        public IEnumerable<T> Parse(Stream stream)
        {
            return OnParse(stream);
        }

        protected virtual IEnumerable<T> OnParse(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            using (var csvReader = new CsvReader(reader))
            {
                csvReader.Configuration.RegisterClassMap<M>();
                return (csvReader.GetRecords<T>().ToArray());
            }
        }
    }
}
