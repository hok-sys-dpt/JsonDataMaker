using BankVision.WebAPI.Models.GW0029.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0029RequestCsvParser : CsvParser<Root<RequestMessageData>, GW0029RequestMap>
    {
    }
}