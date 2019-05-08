using CsvHelper;
using JsonDataMaker.Models.GW0008.Response;

namespace JsonDataMaker.CsvMapper
{
    public class GW0008ResponseMapper: CsvHelper.Configuration.ClassMap<GW0008ResponseJson>
    {
        public GW0008ResponseMapper()
        {
            Map(x => x.FileNo).Name("FileId");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.shoribi).Name("shoribi");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.shoriJikoku).Name("shoriJikoku");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.temban).Name("temban");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.tenmeiKana).Name("tenmeiKana");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.tenmeiKanji).Name("tenmeiKanji");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.kamokuCode).Name("kamokuCode");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.kamokumeiKanji).Name("kamokumeiKanji");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.cifBango).Name("cifBango");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.kozabango).Name("kozabango");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.kozameigiKana).Name("kozameigiKana");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ShokaiKozaJoho.kozameigiKanji).Name("kozameigiKanji");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ZandakaJoho.kozaZandaka).Name("kozaZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ZandakaJoho.shiharaikanoZandaka).Name("shiharaikanoZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ZandakaJoho.zenjitsuZandaka).Name("zenjitsuZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ZandakaJoho.zengetsumatsuZandaka).Name("zengetsumatsuZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ZandakaJoho.zenzengetsumatsuZandaka).Name("zenzengetsumatsuZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.ZandakaJoho.zenzenzengetsumatsuZandaka).Name("zenzenzengetsumatsuZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.VisadebitPointJoho.visadebitUmu).Name("visadebitUmu");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.VisadebitPointJoho.pointZandaka).Name("pointZandaka");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.VisadebitPointJoho.shikkoYoteibi).Name("shikkoYoteibi");
            Map(x => x.ResponseMessageData.YokinkozaZandakashokai.VisadebitPointJoho.shikkoPoint).Name("shikkoPoint");
        }
    }
}