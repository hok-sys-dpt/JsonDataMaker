using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Hox.Biz.BankAccount.Domain
{
    /// <summary>
    /// アプリケーション設定。
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class AppSettings
    {
        /// <summary>
        /// サンプル設定。
        /// </summary>
        public SampleSettings Sample { get; set; }
    }

    /// <summary>
    /// サンプル設定。
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class SampleSettings
    {
        /// <summary>
        /// ItemA。
        /// </summary>
        public string ItemA { get; set; }

        /// <summary>
        /// ItemB。
        /// </summary>
        public string ItemB { get; set; }

        /// <summary>
        /// ItemC。
        /// </summary>
        public string ItemC { get; set; }
    }
}
