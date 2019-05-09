using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonDataMaker.Core.Parsers
{
    public interface IParser<T>
    {
        IEnumerable<T> Parse(Stream stream);
    }
}
