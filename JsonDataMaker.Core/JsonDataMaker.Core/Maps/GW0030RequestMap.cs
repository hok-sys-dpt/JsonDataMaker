using BankVision.WebAPI.Models.GW0030.Request;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0030RequestMap : ClassMap<RequestMessageData>
    {
        public GW0030RequestMap()
        {
            // 商品種別
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.shohinShubetsu)
                .Index(0).Name("shohinShubetsu");
            // 入金口座店番
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.nyukinKozaTemban)
                .Index(1).Name("nyukinKozaTemban");
            // 入金口座科目コード
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.nyukinKozaKamokuCode)
                .Index(2).Name("nyukinKozaKamokuCode");
            // 入金口座番号
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.nyukinKozabango)
                .Index(3).Name("nyukinKozabango");
            // 定期店番
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiTemban)
                .Index(4).Name("teikiTemban");
            // 定期科目コード
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiKamokuCode)
                .Index(5).Name("teikiKamokuCode");
            // 定期科目コード内訳
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiKamokuCodechiwake)
                .Index(6).Name("teikiKamokuCodechiwake");
            // 定期口座番号
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.teikiKozabango)
                .Index(7).Name("teikiKozabango");
            // 受付金額
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.uketsukeKingaku)
                .Index(8).Name("uketsukeKingaku");
            // 確認実行区分
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.kakuninJikkoKubun)
                .Index(9).Name("kakuninJikkoKubun");
            // 支払日
            Map(x => x.Tsumitateteikiyokinshiharai.IbTsumiteiShohinKaiyakuYokyu.shiharaibi)
                .Index(10).Name("shiharaibi");
            // 契約者ID
            Map(x => x.Tsumitateteikiyokinshiharai.KensaKomoku.keiyakushaId)
                .Index(11).Name("keiyakushaId");
        }
    }
}
