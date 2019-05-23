using BankVision.WebAPI.Models.GW0020.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0020RequestCsvParser : CsvParser<RequestMessageData, GW0020RequestMap>
    {
    }
}
