using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace LabelEngine2.Models
{
    class LabelRepository : ILabelRepository
    {
        private const string FILE_EXT = ".json";
        public Dictionary<string, ITemplate> Templates { get; set; }

        public LabelRepository()
        {
            Templates = new Dictionary<string, ITemplate>();
        }

        public void AddFromFile(string filePath)
        {            
            Templates.Add(Path.GetFileNameWithoutExtension(filePath), Newtonsoft.Json.JsonConvert.DeserializeObject<Template>(File.ReadAllText(filePath),
                          new Newtonsoft.Json.JsonSerializerSettings
                          {
                              TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
                              NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,

                          }));
        }

        public void LoadFromFolder(string folderPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            FileInfo[] files;

            files = dirInfo.GetFiles('*' + FILE_EXT);
            foreach (FileInfo file in files)
            {
                AddFromFile(file.FullName);
            }

        }

        public void SaveToFolder(string folderPath)
        {
            foreach (var entry in Templates)
            {

                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer
                {
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                    TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
                    Formatting = Newtonsoft.Json.Formatting.Indented,
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                };

                using (StreamWriter sw = new StreamWriter(Path.Combine(folderPath, entry.Key + FILE_EXT)))
                using (Newtonsoft.Json.JsonWriter writer = new Newtonsoft.Json.JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, entry.Value, typeof(Template));
                }
            }
        }
    }
}
