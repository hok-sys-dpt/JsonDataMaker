using CsvHelper;
using JsonDataMaker.Models.GW1002.Request;

namespace JsonDataMaker.CsvMapper
{
    public class GW1002RequestMapper: CsvHelper.Configuration.ClassMap<GW1002RequestJson>
    {
        public GW1002RequestMapper()
        {
            Map(x => x.FileNo).Name("FileId");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.keiyakushaId).Name("keiyakushaId");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.riyoshaId).Name("riyoshaId");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.taishoKubun).Name("taishoKubun");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.jiMeisaiariHyoji).Name("jiMeisaiariHyoji");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiTemban).Name("tsugiTemban");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiKamokuCode).Name("tsugiKamokuCode");
            Map(x => x.RequestMessageData.BizIbRiyoukozaShokai.KurikaeshiSeigyo.JiMeisaiKey.tsugiKozabango).Name("tsugiKozabango");
        }
    }
}