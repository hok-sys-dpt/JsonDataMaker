using BankVision.WebAPI.Models.GW0008.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0008ResponseCsvParser : CsvParser<Root<ResponseMessageData>, GW0008ResponseMap>
    {
    }
}
