using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace JsonDataMaker.Core.Tests
{
    public class JsonComparer : IEqualityComparer<object>
    {
        public new bool Equals(object x, object y)
        {
            return JsonConvert.SerializeObject(x) == JsonConvert.SerializeObject(y);
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }
}
