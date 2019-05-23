using BankVision.WebAPI.Models.GW0021.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0021RequestCsvParser : CsvParser<RequestMessageData, GW0021RequestMap>
    {
    }
}
