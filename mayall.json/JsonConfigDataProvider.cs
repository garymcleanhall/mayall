using System.IO;

using mayall.contracts;

using Newtonsoft.Json;

namespace mayall.json
{
    public class JsonConfigDataProvider : IConfigDataProvider
    {
        public JsonConfigDataProvider(string filePath)
        {
            this.filePath = filePath;
        }

        public ConfigData GetConfigData()
        {
            var jsonData = File.ReadAllText(filePath);
            var configData = JsonConvert.DeserializeObject<ConfigData>(jsonData);
            return configData;
        }

        public void SetConfigData(ConfigData data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, jsonData);
        }

        private readonly string filePath;
    }
}
