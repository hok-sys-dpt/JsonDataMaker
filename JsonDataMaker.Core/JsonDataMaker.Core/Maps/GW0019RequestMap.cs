using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects.Csv;
using BankVision.WebAPI.Models.GW0019.Request;

namespace JsonDataMaker.Core.Maps
{
    public class GW0019RequestMap : ClassMap<RequestMessageData>
    {
        public GW0019RequestMap()
        {
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.torihikiYokyuKubun).Index(1).Name("torihikiYokyuKubun");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.IraininJoho.iraininTemban).Index(2).Name("iraininTemban");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.IraininJoho.iraininKamokuCode).Index(3).Name("iraininKamokuCode");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.IraininJoho.iraininKozabango).Index(4).Name("iraininKozabango");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininKinyukikanCode).Index(5).Name("uketorininKinyukikanCode");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininKinyukikanmeiKana).Index(6).Name("uketorininKinyukikanmeiKana");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininShitenCode).Index(7).Name("uketorininShitenCode");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininShitenmeiKana).Index(8).Name("uketorininShitenmeiKana");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininKamokuCode).Index(9).Name("uketorininKamokuCode");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininKozabango).Index(10).Name("uketorininKozabango");
            Map(x => x.HurikomisakiKozaShokai.HurikomisakiKozaShokaiYokyu.UketorininJoho.uketorininKanaShimei).Index(11).Name("uketorininKanaShimei");
            Map(x => x.HurikomisakiKozaShokai.KensaKomoku.keiyakushaId).Index(12).Name("keiyakushaId");
        }
    }
}
