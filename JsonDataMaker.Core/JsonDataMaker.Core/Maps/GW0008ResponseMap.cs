using BankVision.WebAPI.Models.GW0008.Response;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0008ResponseMap : ClassMap<Root<ResponseMessageData>>
    {
        public GW0008ResponseMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.YokinkozaZandakashokai.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.YokinkozaZandakashokai.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.temban).Index(3).Name("temban");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.tenmeiKana).Index(4).Name("tenmeiKana");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.tenmeiKanji).Index(5).Name("tenmeiKanji");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.kamokuCode).Index(6).Name("kamokuCode");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.kamokumeiKanji).Index(7).Name("kamokumeiKanji");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.kozabango).Index(8).Name("kozabango");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.cifBango).Index(9).Name("cifBango");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.kozameigiKana).Index(10).Name("kozameigiKana");
            Map(x => x.Data.YokinkozaZandakashokai.ShokaiKozaJoho.kozameigiKanji).Index(11).Name("kozameigiKanji");
            Map(x => x.Data.YokinkozaZandakashokai.ZandakaJoho.kozaZandaka).Index(12).Name("kozaZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.ZandakaJoho.shiharaikanoZandaka).Index(13).Name("shiharaikanoZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.ZandakaJoho.zenjitsuZandaka).Index(14).Name("zenjitsuZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.ZandakaJoho.zengetsumatsuZandaka).Index(15).Name("zengetsumatsuZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.ZandakaJoho.zenzengetsumatsuZandaka).Index(16).Name("zenzengetsumatsuZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.ZandakaJoho.zenzenzengetsumatsuZandaka).Index(17).Name("zenzenzengetsumatsuZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.VisadebitPointJoho.visadebitUmu).Index(18).Name("visadebitUmu");
            Map(x => x.Data.YokinkozaZandakashokai.VisadebitPointJoho.pointZandaka).Index(19).Name("pointZandaka");
            Map(x => x.Data.YokinkozaZandakashokai.VisadebitPointJoho.shikkoYoteibi).Index(20).Name("shikkoYoteibi");
            Map(x => x.Data.YokinkozaZandakashokai.VisadebitPointJoho.shikkoPoint).Index(21).Name("shikkoPoint");
        }
    }
}
