using BankVision.WebAPI.Models.GW0013.Request;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0013RequestMap : ClassMap<Root<RequestMessageData>>
    {
        public GW0013RequestMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.YokyuJoho.temban).Index(0).Name("temban");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.YokyuJoho.kamokuCode).Index(0).Name("kamokuCode");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.YokyuJoho.kozabango).Index(0).Name("kozabango");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.YokyuJoho.kaishibi).Index(0).Name("kaishibi");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.YokyuJoho.shuryobi).Index(0).Name("shuryobi");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.shokaiDaikoShokaiHyoji).Index(0).Name("shokaiDaikoShokaiHyoji");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.jiMeisaiariHyoji).Index(0).Name("jiMeisaiariHyoji");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiSequence).Index(0).Name("tsugiSequence");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.JiMeisaiKey.bunrikichoKubun).Index(0).Name("bunrikichoKubun");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.JiMeisaiKey.hikitsugiZandaka).Index(0).Name("hikitsugiZandaka");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.shokaizumiMeisaiKensu).Index(0).Name("shokaizumiMeisaiKensu");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KensaKomoku.keiyakushaId).Index(0).Name("keiyakushaId");
        }
    }
}
