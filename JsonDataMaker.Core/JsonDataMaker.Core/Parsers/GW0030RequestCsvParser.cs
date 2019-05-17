using BankVision.WebAPI.Models.GW0030.Request;
using JsonDataMaker.Core.DomainObjects.Csv;
using JsonDataMaker.Core.Maps;

namespace JsonDataMaker.Core.Parsers
{
    public class GW0030RequestCsvParser : CsvParser<Root<RequestMessageData>, GW0030RequestMap>
    {
    }
}