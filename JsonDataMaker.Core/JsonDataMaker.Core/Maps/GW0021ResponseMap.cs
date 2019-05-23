using BankVision.WebAPI.Models.GW0021.Response;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0021ResponseMap : ClassMap<Root<ResponseMessageData>>
    {
        public GW0021ResponseMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.Hurikae.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.Hurikae.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.Hurikae.HurikaeJoho.shikinIdobi).Index(3).Name("shikinIdobi");
            Map(x => x.Data.Hurikae.HurikaeJoho.torihikiKingaku).Index(4).Name("torihikiKingaku");
            Map(x => x.Data.Hurikae.HurikaeJoho.tesuryo).Index(5).Name("tesuryo");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinTemban).Index(6).Name("shukkinTemban");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinTenmeiKana).Index(7).Name("shukkinTenmeiKana");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinTenmeiKanji).Index(8).Name("shukkinTenmeiKanji");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinKamokuCode).Index(9).Name("shukkinKamokuCode");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinKamokumeiKanji).Index(10).Name("shukkinKamokumeiKanji");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinKozabango).Index(11).Name("shukkinKozabango");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinCifBango).Index(12).Name("shukkinCifBango");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinKozameigiKana).Index(13).Name("shukkinKozameigiKana");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinKozameigiKanji).Index(14).Name("shukkinKozameigiKanji");
            Map(x => x.Data.Hurikae.ShukkinKoza.shukkinKozaIkanYomikaeHyoji).Index(15).Name("shukkinKozaIkanYomikaeHyoji");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinTemban).Index(16).Name("nyukinTemban");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinTenmeiKana).Index(17).Name("nyukinTenmeiKana");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinTenmeiKanji).Index(18).Name("nyukinTenmeiKanji");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinKamokuCode).Index(19).Name("nyukinKamokuCode");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinKamokumeiKanji).Index(20).Name("nyukinKamokumeiKanji");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinKozabango).Index(21).Name("nyukinKozabango");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinCifBango).Index(22).Name("nyukinCifBango");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinKozameigiKana).Index(23).Name("nyukinKozameigiKana");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinKozameigiKanji).Index(24).Name("nyukinKozameigiKanji");
            Map(x => x.Data.Hurikae.NyukinKoza.nyukinKozaIkanYomikaeHyoji).Index(25).Name("nyukinKozaIkanYomikaeHyoji");
        }
    }
}
