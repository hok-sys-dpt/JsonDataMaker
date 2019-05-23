using BankVision.WebAPI.Models.GW0020.Response;
using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;

namespace JsonDataMaker.Core.Maps
{
    public class GW0020ResponseMap : ClassMap<Root<ResponseMessageData>>
    {
        public GW0020ResponseMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.Data.HurikomiJikko.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.HurikomiJikko.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.kakuninJikkoKubun).Index(3).Name("kakuninJikkoKubun");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.hurikomiShiteibi).Index(4).Name("hurikomiShiteibi");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.hurikomiKingaku).Index(5).Name("hurikomiKingaku");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.tesuryoKingaku).Index(6).Name("tesuryoKingaku");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.konoKeiyakuHyoji).Index(7).Name("konoKeiyakuHyoji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.meisaiBango).Index(8).Name("meisaiBango");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.tesuryoSashihikiHyoji).Index(9).Name("tesuryoSashihikiHyoji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.tesuryokonoHyoji).Index(10).Name("tesuryokonoHyoji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.hurikomisakitorokuyoHyoji).Index(11).Name("hurikomisakitorokuyoHyoji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.hurumaiShijiKodo).Index(12).Name("hurumaiShijiKodo");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininTemban).Index(13).Name("iraininTemban");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininTenmeiKana).Index(14).Name("iraininTenmeiKana");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininTenmeiKanji).Index(15).Name("iraininTenmeiKanji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininKamokuCode).Index(16).Name("iraininKamokuCode");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininKamokumei).Index(17).Name("iraininKamokumei");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininKozabango).Index(18).Name("iraininKozabango");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.IraininJoho.iraininKanaShimei).Index(19).Name("iraininKanaShimei");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKinyukikanCode).Index(20).Name("uketorininKinyukikanCode");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKinyukikanmeiKana).Index(21).Name("uketorininKinyukikanmeiKana");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKinyukikanmeiKanji).Index(22).Name("uketorininKinyukikanmeiKanji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininShitenCode).Index(23).Name("uketorininShitenCode");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininShitenmeiKana).Index(24).Name("uketorininShitenmeiKana");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininShitenmeiKanji).Index(25).Name("uketorininShitenmeiKanji");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKamokuCode).Index(26).Name("uketorininKamokuCode");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKamokumei).Index(27).Name("uketorininKamokumei");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKozabango).Index(28).Name("uketorininKozabango");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininmeiKana).Index(29).Name("uketorininmeiKana");
            Map(x => x.Data.HurikomiJikko.HurikomiJikkoOto.UketorininJoho.uketorininKozabango).Index(30).Name("uketorininKozabango");
        }
    }
}
