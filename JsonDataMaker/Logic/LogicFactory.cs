using System;
using Autofac.Features.Indexed;

namespace JsonDataMaker.Logic
{
    public class LogicFactory
    {
        private const string request = "request";
        private IIndex<string, IGWLogic> _logics;

        public LogicFactory(IIndex<string, IGWLogic> logics)
        {
            _logics = logics;
        }

        ///<summary>
        /// API Logic を作成
        ///</summary>
        ///<param name="gWnumber">GW番号</param>
        ///<param name="reqOrRes">request or response</param>
        public IGWLogic CreateLogic(string gWnumber, string reqOrRes)
        {
            return _logics[$"{gWnumber}:{reqOrRes}"];
        }
    }
}