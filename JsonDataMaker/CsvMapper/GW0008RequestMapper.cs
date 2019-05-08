using CsvHelper;
using JsonDataMaker.Models.GW0008.Request;

namespace JsonDataMaker.CsvMapper
{
    public class GW0008RequestMapper: CsvHelper.Configuration.ClassMap<GW0008RequestJson>
    {
        public GW0008RequestMapper()
        {
            Map(x => x.FileNo).Name("FileId");
            Map(x => x.RequestMessageData.YokinkozaZandakashokai.ShokaiKomoku.temban).Name("temban");
            Map(x => x.RequestMessageData.YokinkozaZandakashokai.ShokaiKomoku.kamokuCode).Name("kamokuCode");
            Map(x => x.RequestMessageData.YokinkozaZandakashokai.ShokaiKomoku.kozabango).Name("kozabango");
            Map(x => x.RequestMessageData.YokinkozaZandakashokai.ShokaiKomoku.kaburiKubun).Name("kaburiKubun");
            Map(x => x.RequestMessageData.YokinkozaZandakashokai.KensaKomoku.keiyakushaId).Name("keiyakushaId");
        }
    }
}