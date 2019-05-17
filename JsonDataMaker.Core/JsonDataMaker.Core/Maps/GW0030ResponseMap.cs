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
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.shohinShubetsu).Index(1).Name("shohinShubetsu");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.nyukinKozaTemban).Index(2).Name("nyukinKozaTemban");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.nyukinKozaKamokuCode).Index(3).Name("nyukinKozaKamokuCode");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.nyukinKozabango).Index(4).Name("nyukinKozabango");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiTemban).Index(5).Name("teikiTemban");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiKamokuCode).Index(6).Name("teikiKamokuCode");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiKamokuCodechiwake).Index(7).Name("teikiKamokuCodechiwake");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiKozabango).Index(8).Name("teikiKozabango");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.uketsukeKingaku).Index(9).Name("uketsukeKingaku");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.kakuninJikkoKubun).Index(10).Name("kakuninJikkoKubun");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.shiharaibi).Index(11).Name("shiharaibi");
            Map(x => x.Data.Tsumitateteikiyokinshiharai.KensaKomoku.keiyakushaId).Index(12).Name("teikiTemban");
        }
    }
}
