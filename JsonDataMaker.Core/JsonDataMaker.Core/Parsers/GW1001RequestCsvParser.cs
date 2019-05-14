using JsonDataMaker.Core.DomainObjects;
using BankVision.WebAPI.Models.GW1001.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW1001RequestCsvParser : CsvParser<Root<RequestMessageData>, GW1001RequestMap>
    {
    }
}