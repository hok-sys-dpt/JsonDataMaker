using BankVision.WebAPI.Models.GW0008.Request;

namespace JsonDataMaker.Core.DomainObjects
{
    public class GW0008RequestObject
    {
        /// <summary>
        /// ファイルID
        /// </summary>
        public int FileId { get; set; }
        public RequestMessageData RequestMessageData { get; set; }
    }
}
