using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;
using BankVision.WebAPI.Models.GW0021.Request;

namespace JsonDataMaker.Core.Maps
{
    public class GW0021RequestMap : ClassMap<RequestMessageData>
    {
        public GW0021RequestMap()
        {
            Map(x => x.Hurikae.TorihikiKomoku.shikinIdobi).Index(1).Name("shikinIdobi");
            Map(x => x.Hurikae.TorihikiKomoku.kakuninJikkoKubun).Index(2).Name("kakuninJikkoKubun");
            Map(x => x.Hurikae.TorihikiKomoku.sokujiyoyakuKubun).Index(3).Name("sokujiyoyakuKubun");
            Map(x => x.Hurikae.TorihikiKomoku.ShukkinKoza.shukkinTemban).Index(4).Name("shukkinTemban");
            Map(x => x.Hurikae.TorihikiKomoku.ShukkinKoza.shukkinKamokuCode).Index(5).Name("shukkinKamokuCode");
            Map(x => x.Hurikae.TorihikiKomoku.ShukkinKoza.shukkinKozabango).Index(6).Name("shukkinKozabango");
            Map(x => x.Hurikae.TorihikiKomoku.NyukinKoza.nyukinTemban).Index(7).Name("nyukinTemban");
            Map(x => x.Hurikae.TorihikiKomoku.NyukinKoza.nyukinKamokuCode).Index(8).Name("nyukinKamokuCode");
            Map(x => x.Hurikae.TorihikiKomoku.NyukinKoza.nyukinKozabango).Index(9).Name("nyukinKozabango");
            Map(x => x.Hurikae.TorihikiKomoku.torihikiKingaku).Index(10).Name("torihikiKingaku");
            Map(x => x.Hurikae.KensaKomoku.keiyakushaId).Index(11).Name("keiyakushaId");
        }
    }
}
