using System.Collections.Generic;

namespace LabelEngine2.Models
{
    public interface ILabelRepository
    {
        Dictionary<string, ITemplate> Templates { get; set; }

        void LoadFromFolder(string folderPath);
        void SaveToFolder(string folderPath);
        void AddFromFile(string filePath);
    }
}
