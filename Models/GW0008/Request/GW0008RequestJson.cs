using BankVision.WebAPI.Models.GW0008.Request;

namespace JsonDataMaker.Models.GW0008.Request
{
    public class GW0008RequestJson
    {
        public int FileNo { get; set; }
        public RequestMessageData RequestMessageData { get; set; }
    }
}