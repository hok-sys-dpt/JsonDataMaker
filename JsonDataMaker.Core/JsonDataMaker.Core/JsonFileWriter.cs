using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDataMaker.Core
{
    public class JsonFileWriter : IJsonWriter
    {
        public async Task<Stream> CreateAsync(object value, string path)
        {
            var writer = File.CreateText(path);
            await writer.WriteAsync(JsonConvert.SerializeObject(value, Formatting.Indented));
            await writer.FlushAsync();
            return writer.BaseStream;
        }
    }
}
