using BankVision.WebAPI.Models.GW1001.Request;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW1001RequestMap : ClassMap<Root<RequestMessageData>>
    {
        public GW1001RequestMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.BizIbKeiyakushaJohoShokai.keiyakushaId).Index(1).Name("keiyakushaId");
            Map(x => x.Data.BizIbKeiyakushaJohoShokai.temban).Index(2).Name("temban");
            Map(x => x.Data.BizIbKeiyakushaJohoShokai.kamokuCode).Index(3).Name("kamokuCode");
            Map(x => x.Data.BizIbKeiyakushaJohoShokai.kozabango).Index(4).Name("kozabango");
        }
    }
}