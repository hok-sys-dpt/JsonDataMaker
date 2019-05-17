using BankVision.WebAPI.Models.GW0029.Response;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0029ResponseMap : ClassMap<Root<ResponseMessageData>>
    {
        public GW0029ResponseMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.yonyubi).Index(3).Name("yonyubi");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.shohinShubetsu).Index(4).Name("shohinShubetsu");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.shohinMeisho).Index(5).Name("shohinMeisho");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.nyukinKozaTemban).Index(6).Name("nyukinKozaTemban");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.nyukinKozaTenmei).Index(7).Name("nyukinKozaTenmei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.nyukinKozaTenmeiKana).Index(8).Name("nyukinKozaTenmeiKana");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.nyukinKozaKamokuCode).Index(9).Name("nyukinKozaKamokuCode");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.nyukinKozaKamokumei).Index(10).Name("nyukinKozaKamokumei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.nyukinKozabango).Index(11).Name("nyukinKozabango");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiTemban).Index(12).Name("teikiTemban");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiTenmei).Index(13).Name("teikiTenmei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiTenmeiKana).Index(14).Name("teikiTenmeiKana");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiKamokuCode).Index(15).Name("teikiKamokuCode");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiKamokuCodechiwake).Index(16).Name("teikiKamokuCodechiwake");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiKamokumei).Index(17).Name("teikiKamokumei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiKozabango).Index(18).Name("teikiKozabango");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.yonyuKikan).Index(19).Name("yonyuKikan");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.yonyuKikanMongon).Index(20).Name("yonyuKikanMongon");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.mankibi).Index(21).Name("mankibi");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.riritsu).Index(22).Name("riritsu");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.keizokuKubun).Index(23).Name("keizokuKubun");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.keizokuKubunMeisho).Index(24).Name("keizokuKubunMeisho");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.kazeiKubun).Index(25).Name("kazeiKubun");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.kazeiKubunMeisho).Index(26).Name("kazeiKubunMeisho");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.uketsukeKingaku).Index(27).Name("uketsukeKingaku");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.risoku).Index(28).Name("risoku");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.sashihikiShiharaiKingaku).Index(29).Name("sashihikiShiharaiKingaku");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.zeiGokei).Index(30).Name("zeiGokei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.uchiKokuzei).Index(31).Name("uchiKokuzei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.uchiChihozei).Index(32).Name("uchiChihozei");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.teikiyokinHurikaeKingaku).Index(33).Name("teikiyokinHurikaeKingaku");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.shiteiKozaFurikaeKingaku).Index(34).Name("shiteiKozaFurikaeKingaku");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.shiharaibi).Index(35).Name("shiharaibi");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.gankin).Index(36).Name("gankin");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.yonyuBango).Index(37).Name("yonyuBango");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.kakuninJikkoKubun).Index(38).Name("kakuninJikkoKubun");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.keiyakushaId).Index(39).Name("keiyakushaId");
            Map(x => x.Data.Teikiyokinshiharai.IbTeikiShohinKaiyakuOto.meisaiBango).Index(40).Name("meisaiBango");
        }
    }

}
