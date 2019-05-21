using BankVision.WebAPI.Models.GW0019.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0019ResponseCsvParser : CsvParser<Root<ResponseMessageData>,GW0019ResponseMap>
    {
    }
}
