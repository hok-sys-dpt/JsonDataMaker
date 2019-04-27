using BankVision.WebAPI.Models.GW1002.Request;

namespace JsonDataMaker.Models.GW1002.Request
{
    public class GW1002RequestJson
    {
        public int FileNo { get; set; }
        public RequestMessageData RequestMessageData { get; set; }
    }
}