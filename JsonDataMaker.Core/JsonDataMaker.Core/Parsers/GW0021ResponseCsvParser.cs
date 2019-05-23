using BankVision.WebAPI.Models.GW0021.Response;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0021ResponseCsvParser : CsvParser<Root<ResponseMessageData>,GW0021ResponseMap>
    {
    }
}
