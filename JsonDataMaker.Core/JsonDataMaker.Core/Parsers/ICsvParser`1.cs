using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonDataMaker.Core.Parsers
{
    public interface ICsvParser<T> : IParser<T>
    {
        IEnumerable<T> Parse(params Stream[] streams);
    }
}
