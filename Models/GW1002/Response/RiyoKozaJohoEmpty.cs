using BankVision.WebAPI.Models.GW1002.Response;

namespace jsondatamaker.Models.GW1002.Response
{
    public class RiyoKozaJohoEmpty : RiyoKozaJoho
    {
        public RiyoKozaJohoEmpty()
        {
            cifBango = 0;
            daihyoKozaHyoji = 0;
            kamokuCode = 0;
            kamokuCodeUchiwake = 0;
            kozaMemo = "";
            kozabango = 0;
            kozameigiKana = "";
            kozameigiKanji = "";
            orgId = 0;
            sakuinyoKozameigiKana = "";
            temban = 0;
            tenmeiKana = "";
            tenmeiKanji = "";
            tsukaCode = "";
        }
    }
}