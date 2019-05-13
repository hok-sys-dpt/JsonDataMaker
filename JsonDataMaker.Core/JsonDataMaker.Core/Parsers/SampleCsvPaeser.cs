using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class SampleCsvPaeser : CsvParser<Root<Sample>, SampleMap>
    {
    }
}
