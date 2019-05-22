using BankVision.WebAPI.Models.GW0030.Response;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0030ResponseMap : ClassMap<Root<ResponseMessageData>>
    {
        public GW0030ResponseMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.yonyubi).Index(3).Name("yonyubi");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.shohinShubetsu).Index(4).Name("shohinShubetsu");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.shohinMeisho).Index(5).Name("shohinMeisho");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.nyukinKozaTemban).Index(6).Name("nyukinKozaTemban");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.nyukinKozaTenmei).Index(7).Name("nyukinKozaTenmei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.nyukinKozaTenmeiKana).Index(8).Name("nyukinKozaTenmeiKana");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.nyukinKozaKamokuCode).Index(9).Name("nyukinKozaKamokuCode");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.nyukinKozaKamokumei).Index(10).Name("nyukinKozaKamokumei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.nyukinKozabango).Index(11).Name("nyukinKozabango");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiTemban).Index(12).Name("teikiTemban");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiTenmei).Index(13).Name("teikiTenmei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiTenmeiKana).Index(14).Name("teikiTenmeiKana");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiKamokuCode).Index(15).Name("teikiKamokuCode");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiKamokuCodechiwake).Index(16).Name("teikiKamokuCodechiwake");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiKamokumei).Index(17).Name("teikiKamokumei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiKozabango).Index(18).Name("teikiKozabango");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.yonyuKikan).Index(19).Name("yonyuKikan");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.mankibi).Index(20).Name("mankibi");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.riritsu).Index(21).Name("riritsu");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.keizokuKubun).Index(22).Name("keizokuKubun");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.keizokuKubunMeisho).Index(23).Name("keizokuKubunMeisho");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.kazeiKubun).Index(24).Name("kazeiKubun");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.kazeiKubunMeisho).Index(25).Name("kazeiKubunMeisho");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.uketsukeKingaku).Index(26).Name("uketsukeKingaku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.risoku).Index(27).Name("risoku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.sashihikiShiharaiKingaku).Index(28).Name("sashihikiShiharaiKingaku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.zeiGokei).Index(29).Name("zeiGokei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.uchiKokuzei).Index(30).Name("uchiKokuzei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.uchiChihozei).Index(31).Name("uchiChihozei");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.sogoKozaFurikaeKingaku).Index(32).Name("sogoKozaFurikaeKingaku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.kashikoshiRisoku).Index(33).Name("kashikoshiRisoku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.teikiyokinHurikaeKingaku).Index(34).Name("teikiyokinHurikaeKingaku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.shiteiKozaFurikaeKingaku).Index(35).Name("shiteiKozaFurikaeKingaku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.shiharaibi).Index(36).Name("shiharaibi");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.gankin).Index(37).Name("gankin");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.yonyuBango).Index(38).Name("yonyuBango");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.kakuninJikkoKubun).Index(39).Name("kakuninJikkoKubun");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.keiyakushaId).Index(40).Name("keiyakushaId");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuOto.meisaiBango).Index(41).Name("meisaiBango");
        }
    }
}
