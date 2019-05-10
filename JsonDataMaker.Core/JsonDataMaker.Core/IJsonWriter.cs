using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataMaker.Core
{
    public interface IJsonWriter
    {
        Task<Stream> CreateAsync(object value, string path);
    }
}
