using System.Collections.Generic;
using System.Data;

namespace LabelEngine2.Models
{
    public interface IDataProvider
    {
        List<Dictionary<string, string>> Data { get; set; }
        DataTable Table { get; }
        void OnTableChanged();
        void Load(string filePath);
        void Save(string filePath);
        void CreateNew();
    }
}
