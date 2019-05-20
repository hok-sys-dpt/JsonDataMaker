using BankVision.WebAPI.Models.GW0029.Request;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0029RequestMap : ClassMap<RequestMessageData>
    {
        public GW0029RequestMap()
        {
            // 商品種別
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.shohinShubetsu)
                .Index(0).Name("shohinShubetsu");
            // 入金口座店番
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.nyukinKozaTemban)
                .Index(1).Name("nyukinKozaTemban");
            // 入金口座科目コード
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.nyukinKozaKamokuCode)
                .Index(2).Name("nyukinKozaKamokuCode");
            // 入金口座番号
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.nyukinKozabango)
                .Index(3).Name("nyukinKozabango");
            // 定期店番
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiTemban)
                .Index(4).Name("teikiTemban");
            // 定期科目コード
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiKamokuCode)
                .Index(5).Name("teikiKamokuCode");
            // 定期科目コード内訳
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiKamokuCodechiwake)
                .Index(6).Name("teikiKamokuCodechiwake");
            // 定期口座番号
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.teikiKozabango)
                .Index(7).Name("teikiKozabango");
            // 預入番号
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.yonyuBango)
                .Index(8).Name("yonyuBango");
            // 受付金額
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.uketsukeKingaku)
                .Index(9).Name("uketsukeKingaku");
            // 確認実行区分
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.kakuninJikkoKubun)
                .Index(10).Name("kakuninJikkoKubun");
            // 支払日
            Map(x => x.Teikiyokinshiharai.IbTeikiShohinKaiyakuYokyu.shiharaibi)
                .Index(11).Name("shiharaibi");
            // 契約者ID
            Map(x => x.Teikiyokinshiharai.KensaKomoku.keiyakushaId)
                .Index(12).Name("keiyakushaId");
        }
    }
}
