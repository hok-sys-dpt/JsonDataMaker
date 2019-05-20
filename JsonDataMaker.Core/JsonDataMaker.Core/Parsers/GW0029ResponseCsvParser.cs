using BankVision.WebAPI.Models.GW0029.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0029ResponseCsvParser : CsvParser<Root<ResponseMessageData>, GW0029ResponseMap>
    {
    }
}