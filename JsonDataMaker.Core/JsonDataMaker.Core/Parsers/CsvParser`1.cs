using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace JsonDataMaker.Core.Parsers
{
    public class CsvParser<T> : ICsvParser
    {
        public IEnumerable<T> Parse(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            using (var csvReader = new CsvReader(reader))
            {
                csvReader.Configuration.RegisterClassMap(typeof(ClassMap<T>));
                return (csvReader.GetRecords<T>().ToArray());
            }
        }
    }
}
