using System.Globalization;
using System.IO;
using Newtonsoft.Json;

namespace JsonDataMaker
{
    public class JsonFileWriter
    {
        ///<summary>
        /// Jsonファイル作成
        ///</summary>
        ///<param name="model">jsonにシリアライズするクラスを指定</param>
        ///<param name="apino">api番号</param>
        ///<param name="reqOrRes">request or response</param>
        ///<param name="outputpath">ファイル出力先</param>
        public void New(object model, int fileId, string apino, string reqOrRes, string outputpath)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            var jsondata = JsonConvert.SerializeObject(model, Formatting.Indented);
            StreamWriter writer = new StreamWriter($"{outputpath}/{apino}{myTI.ToTitleCase(reqOrRes)}{fileId:D4}.json", false);
            
            writer.WriteLine(jsondata);
            writer.Close();
        }
    }
}