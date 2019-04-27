using BankVision.WebAPI.Models.Common;
using System;

namespace jsondatamaker.Models
{
    public class WisRequestSystemInfoValue : WisRequestSystemInfo
    {
        public WisRequestSystemInfoValue()
        {
            version = "";
            clientId = "CB02";
            clientTraceId = Guid.NewGuid().ToString();
            transactionId = "";
            requestType = 0;
            clientKey = "E1234CC5-6789-0AB1-2345-67890AC1F23";
        }
    }
}