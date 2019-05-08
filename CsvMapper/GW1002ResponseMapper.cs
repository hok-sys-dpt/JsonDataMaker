using CsvHelper;
using JsonDataMaker.Models.GW1002.Response;

namespace JsonDataMaker.CsvMapper
{
    public class GW1002ResponseMapper: CsvHelper.Configuration.ClassMap<GW1002ResponseJson>
    {
        public GW1002ResponseMapper()
        {
            Map(x => x.FileNo).Name("FileId");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.shoribi).Name("shoribi");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.shoriJikoku).Name("shoriJikoku");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.otoKensu).Name("otoKensu");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.jiMeisaiariHyoji).Name("jiMeisaiariHyoji");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiTemban).Name("tsugiTemban");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiKamokuCode).Name("tsugiKamokuCode");
            Map(x => x.ResponseMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiKozabango).Name("tsugiKozabango");
        }
    }
}