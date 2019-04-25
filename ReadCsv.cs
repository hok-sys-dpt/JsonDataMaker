using System.Collections.Generic;
using System.Linq;
using CsvHelper;

namespace JsonDataMaker
{
    public class ReadCsv
    {
        public IEnumerable<T> Fetcher<T, M>(CsvReader csv) where M: CsvHelper.Configuration.ClassMap<T>
        {
            csv.Configuration.RegisterClassMap<M>();
            return(csv.GetRecords<T>().ToArray());            
        }
    }
}