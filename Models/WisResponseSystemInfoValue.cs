using System;
using BankVision.WebAPI.Models.Common;

namespace jsondatamaker.Models
{
    public class WisResponseSystemInfoValue : WisResponseSystemInfo
    {
        public WisResponseSystemInfoValue()
        {
            version = "";
            transactionId = "51-1_" + Guid.NewGuid().ToString().Substring(25);
            result = 0;
            resultCode = "000000";
            resultDetail = null;
        }
    }
}