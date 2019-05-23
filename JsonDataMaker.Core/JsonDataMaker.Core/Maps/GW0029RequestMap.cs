using BankVision.WebAPI.Models.GW0029.Request;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0029RequestMap : ClassMap<RequestMessageData>
    {
        public GW0029RequestMap()
        {
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.shohinShubetsu)
                .Index(0).Name("shohinShubetsu");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.nyukinKozaTemban)
                .Index(1).Name("nyukinKozaTemban");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.nyukinKozaKamokuCode)
                .Index(2).Name("nyukinKozaKamokuCode");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.nyukinKozabango)
                .Index(3).Name("nyukinKozabango");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiTemban)
                .Index(4).Name("teikiTemban");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiKamokuCode)
                .Index(5).Name("teikiKamokuCode");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiKamokuCodechiwake)
                .Index(6).Name("teikiKamokuCodechiwake");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiKozabango)
                .Index(7).Name("teikiKozabango");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.yonyuBango)
                .Index(8).Name("yonyuBango");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.uketsukeKingaku)
                .Index(9).Name("uketsukeKingaku");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.kakuninJikkoKubun)
                .Index(10).Name("kakuninJikkoKubun");
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.shiharaibi)
                .Index(11).Name("shiharaibi");
            Map(x => x.Teikiyokinshiharai.KensaKomoku.keiyakushaId)
                .Index(12).Name("keiyakushaId");
        }
    }
}
