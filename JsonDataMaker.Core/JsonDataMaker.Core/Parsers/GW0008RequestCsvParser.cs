using BankVision.WebAPI.Models.GW0008.Request;
using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0008RequestCsvParser : CsvParser<Root<RequestMessageData>, GW0008RequestMap>
    {
    }
}
