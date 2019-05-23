using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;
using BankVision.WebAPI.Models.GW0020.Request;

namespace JsonDataMaker.Core.Maps
{
    public class GW0020RequestMap : ClassMap<RequestMessageData>
    {
        public GW0020RequestMap()
        {
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.kakuninJikkoKubun).Index(1).Name("kakuninJikkoKubun");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.hurikomiShiteibi).Index(2).Name("hurikomiShiteibi");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.hurikomiKingaku).Index(3).Name("hurikomiKingaku");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.tesuryoSashihikiHyoji).Index(4).Name("tesuryoSashihikiHyoji");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.tesuryokonoHyoji).Index(5).Name("tesuryokonoHyoji");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.hurikomisakitorokuyoHyoji).Index(6).Name("hurikomisakitorokuyoHyoji");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.uketorininShiteiKubun).Index(7).Name("uketorininShiteiKubun");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.uketorininTenyuryokuHyoji).Index(8).Name("uketorininTenyuryokuHyoji");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.uketorininShiteiKubun).Index(9).Name("uketorininShiteiKubun");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.uketorininTenyuryokuHyoji).Index(10).Name("uketorininTenyuryokuHyoji");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.kakuninjiTesuryoKingaku).Index(11).Name("kakuninjiTesuryoKingaku");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.chokkinkozakakuninTRXID).Index(12).Name("chokkinkozakakuninTRXID");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.torokuBango).Index(13).Name("torokuBango");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.IraininJoho.iraininTemban).Index(14).Name("iraininTemban");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.IraininJoho.iraininKamokuCode).Index(15).Name("iraininKamokuCode");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.IraininJoho.iraininKozabango).Index(16).Name("iraininKozabango");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.IraininJoho.iraininmeiKana).Index(17).Name("iraininmeiKana");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininKinyukikanCode).Index(18).Name("uketorininKinyukikanCode");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininKinyukikanmeiKana).Index(19).Name("uketorininKinyukikanmeiKana");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininShitenCode).Index(20).Name("uketorininShitenCode");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininShitenmeiKana).Index(21).Name("uketorininShitenmeiKana");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininKamokuCode).Index(22).Name("uketorininKamokuCode");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininKozabango).Index(23).Name("uketorininKozabango");
            Map(x => x.HurikomiJikko.HurikomiJikkoYokyu.UketorininJoho.uketorininmeiKana).Index(24).Name("uketorininmeiKana");
        }
    }
}
