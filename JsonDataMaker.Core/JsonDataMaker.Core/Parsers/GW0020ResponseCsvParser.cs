using BankVision.WebAPI.Models.GW0020.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0020ResponseCsvParser : CsvParser<Root<ResponseMessageData>,GW0020ResponseMap>
    {
    }
}
