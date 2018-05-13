using Newtonsoft.Json;
using System.IO;

namespace LabelEngine2
{
    static class ConfigurationManager
    {
        private static AppConfig _config;
        public static AppConfig AppConfig { get => _config; }

        static ConfigurationManager()
        {
            _config = new AppConfig();
        }

        public static void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл конфигурации не найден!");
            _config = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(filePath),
                           new JsonSerializerSettings
                           {
                               TypeNameHandling = TypeNameHandling.Auto,
                               NullValueHandling = NullValueHandling.Ignore,

                           });
        }

        public static void SaveToFile(string filePath)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
                ObjectCreationHandling = ObjectCreationHandling.Replace
            };

            using (StreamWriter sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _config, typeof(AppConfig));
            }
        }
    }
}