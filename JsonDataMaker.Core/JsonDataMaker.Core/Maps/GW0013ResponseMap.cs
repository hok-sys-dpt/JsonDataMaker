using BankVision.WebAPI.Models.GW0013.Response;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0013ResponseMap : ClassMap<Root<ResponseMessageData>>
    {
        public GW0013ResponseMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KozaJoho.temban).Index(3).Name("temban");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KozaJoho.tenmeiKana).Index(4).Name("tenmeiKana");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KozaJoho.tenmeiKanji).Index(5).Name("tenmeiKanji");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KozaJoho.kamokuCode).Index(6).Name("kamokuCode");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KozaJoho.kamokumeiKanji).Index(7).Name("kamokumeiKanji");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KozaJoho.kozabango).Index(8).Name("kozabango");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.shokaiDaikoShokaiHyoji).Index(9).Name("shokaiDaikoShokaiHyoji");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.jiMeisaiariHyoji).Index(10).Name("jiMeisaiariHyoji");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiSequence).Index(11).Name("tsugiSequence");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.JiMeisaiKey.bunrikichoKubun).Index(12).Name("bunrikichoKubun");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.JiMeisaiKey.hikitsugiZandaka).Index(13).Name("hikitsugiZandaka");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.KurikaeshiSeigyo.shokaizumiMeisaiKensu).Index(14).Name("shokaizumiMeisaiKensu");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.otoKensu).Index(15).Name("otoKensu");
            Map(x => x.Data.GaikaYokinNyushukkinMeisaiShokai.MeisaiJoho).Ignore();
        }
    }

    public class GW0013MeisaiJohoMap : ClassMap<MeisaiJoho>
    {
        public GW0013MeisaiJohoMap()
        {
            Map(x => x.sequence).Index(0).Name("sequence");
            Map(x => x.torihikibi).Index(1).Name("torihikibi");
            Map(x => x.torihikiJikoku).Index(2).Name("torihikiJikoku");
            Map(x => x.iriharaiKubun).Index(3).Name("iriharaiKubun");
            Map(x => x.torihikiKingaku).Index(4).Name("torihikiKingaku");
            Map(x => x.hyomenZandaka).Index(5).Name("hyomenZandaka");
            Map(x => x.tsukaCode).Index(6).Name("tsukaCode");
            Map(x => x.tsukaMeisho).Index(7).Name("tsukaMeisho");
            Map(x => x.tekiyoKanji).Index(8).Name("tekiyoKanji");
            Map(x => x.tekiyoKana).Index(9).Name("tekiyoKana");
        }
    }
}
