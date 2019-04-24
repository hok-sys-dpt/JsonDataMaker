using CsvHelper;
using BankVision.WebAPI.Models.GW1002.Response;
using JsonDataMaker.Models.GW1012.Response;

namespace JsonDataMaker.CsvMapper
{
    public class GW1002ResponseListMapper: CsvHelper.Configuration.ClassMap<GW1002ResponseList>
    {
        public GW1002ResponseListMapper()
        {
            Map(x => x.FileId).Name("FileId");
            Map(x => x.RiyoKozaJoho.cifBango).Name("cifBango");
            Map(x => x.RiyoKozaJoho.daihyoKozaHyoji).Name("daihyoKozaHyoji");
            Map(x => x.RiyoKozaJoho.kamokuCode).Name("kamokuCode");
            Map(x => x.RiyoKozaJoho.kamokuCodeUchiwake).Name("kamokuCodeUchiwake");
            Map(x => x.RiyoKozaJoho.kozaMemo).Name("kozaMemo");
            Map(x => x.RiyoKozaJoho.kozabango).Name("kozabango");
            Map(x => x.RiyoKozaJoho.kozameigiKana).Name("kozameigiKana");
            Map(x => x.RiyoKozaJoho.kozameigiKanji).Name("kozameigiKanji");
            Map(x => x.RiyoKozaJoho.orgId).Name("orgId");
            Map(x => x.RiyoKozaJoho.sakuinyoKozameigiKana).Name("sakuinyoKozameigiKana");
            Map(x => x.RiyoKozaJoho.temban).Name("temban");
            Map(x => x.RiyoKozaJoho.tenmeiKana).Name("tenmeiKana");
            Map(x => x.RiyoKozaJoho.tenmeiKanji).Name("tenmeiKanji");
            Map(x => x.RiyoKozaJoho.tsukaCode).Name("tsukaCode");
        }
    }
}