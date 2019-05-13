using BankVision.WebAPI.Models.GW1001.Request;

namespace JsonDataMaker.Core.DomainObjects
{
    public class GW1001RequestObject
    {
        public int FileId { get; set; }
        public RequestMessageData RequestMessageData { get; set; }
    }
}