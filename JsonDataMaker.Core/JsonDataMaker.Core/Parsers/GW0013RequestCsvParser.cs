using BankVision.WebAPI.Models.GW0013.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0013RequestCsvParser : CsvParser<Root<RequestMessageData>, GW0013RequestMap>
    {
    }
}
