using BankVision.WebAPI.Models.GW0030.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0030ResponseCsvParser : CsvParser<Root<ResponseMessageData>, GW0030ResponseMap>
    {
    }
}