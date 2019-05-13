using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;

namespace JsonDataMaker.Core.Maps
{
    public class GW1001RequestMap : ClassMap<GW1001RequestObject>
    {
        public GW1001RequestMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.RequestMessageData.BizIbKeiyakushaJohoShokai.keiyakushaId).Index(1).Name("keiyakushaId");
            Map(x => x.RequestMessageData.BizIbKeiyakushaJohoShokai.temban).Index(2).Name("temban");
            Map(x => x.RequestMessageData.BizIbKeiyakushaJohoShokai.kamokuCode).Index(3).Name("kamokuCode");
            Map(x => x.RequestMessageData.BizIbKeiyakushaJohoShokai.kozabango).Index(4).Name("kozabango");
        }
    }
}