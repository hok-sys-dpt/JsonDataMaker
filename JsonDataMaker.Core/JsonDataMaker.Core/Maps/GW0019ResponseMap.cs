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
            Map(x => x.Data.HurikomisakiKozaShokai.shoribi).Index(1).Name("shoribi");
            Map(x => x.Data.HurikomisakiKozaShokai.shoriJikoku).Index(2).Name("shoriJikoku");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.hurikomiJisshiKahi).Index(3).Name("hurikomiJisshiKahi");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.shokaiKekkaChikanKubun).Index(4).Name("shokaiKekkaChikanKubun");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.kozaKakuninTRXID).Index(5).Name("kozaKakuninTRXID");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKinyukikanCode).Index(6).Name("uketorininKinyukikanCode");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKinyukikanmeiKana).Index(7).Name("uketorininKinyukikanmeiKana");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKinyukikanmeiKanji).Index(8).Name("uketorininKinyukikanmeiKanji");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininShitenCode).Index(9).Name("uketorininShitenCode");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininShitenmeiKana).Index(10).Name("uketorininShitenmeiKana");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininShitenmeiKanji).Index(11).Name("uketorininShitenmeiKanji");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKamokuCode).Index(12).Name("uketorininKamokuCode");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKamokumei).Index(13).Name("uketorininKamokumei");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKozabango).Index(14).Name("uketorininKozabango");
            Map(x => x.Data.HurikomisakiKozaShokai.HurikomisakiKozaShokaiOto.UketorininJoho.uketorininKanaShimei).Index(15).Name("uketorininKanaShimei");
        }
    }
}
