using CsvHelper;

namespace JsonDataMaker.Controller
{
    public interface IGWLogic
    {
        void CreateData(string outputpath, CsvReader csv);
        void CreateListData(string outputpath, CsvReader csv1, CsvReader csv2);
    }
}