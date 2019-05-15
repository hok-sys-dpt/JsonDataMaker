using BankVision.WebAPI.Models.GW0008.Request;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0008RequestMap : ClassMap<Root<RequestMessageData>>
    {
        public GW0008RequestMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKomoku.temban).Index(1).Name("temban");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKomoku.kamokuCode).Index(2).Name("kamokuCode");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKomoku.kozabango).Index(3).Name("kozabango");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKomoku.kaburiKubun).Index(4).Name("kaburiKubun");
            Map(x => x.Data.YokinkozaZandakashokai.KensaKomoku.keiyakushaId).Index(5).Name("keiyakushaId");
        }
    }
}
