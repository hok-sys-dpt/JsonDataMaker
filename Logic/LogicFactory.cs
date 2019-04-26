using System;

namespace JsonDataMaker.Logic
{
    public class LogicFactory
    {
        private const string request = "request";
        private const string response = "response";
        
        ///<summary>
        /// API Logic を作成
        ///</summary>
        ///<param name="gWnumber">GW番号</param>
        ///<param name="reqOrRes">request or response</param>
        public IGWLogic CreateLogic(string gWnumber, string reqOrRes, CsvFetcher csv, JsonFileWriter jf)
        {
            switch (gWnumber)
            {
                case "GW0008":
                    {
                        if (reqOrRes == request)
                            return new GW0008RequestLogic(csv, jf);
                        return new GW0008ResponseLogic(csv, jf);
                    }
                case "GW1002":
                    {
                        if (reqOrRes == request)
                            return new GW1002RequestLogic(csv, jf);
                        return new GW1002ResponseLogic(csv, jf);
                }
                default:
                    throw new ArgumentException("\n対象のファクトリがありませんでした");
            }
        }
    }
}