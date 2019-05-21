using System;
using System.Collections.Generic;
using System.Text;
using BankVision.WebAPI.Models.GW0019.Response;

namespace JsonDataMaker.Core.DomainObjects.Csv
{
    public class Root<T>
    {
        public int FileId { get; set; }

        public T Data { get; set; }
    }
}
