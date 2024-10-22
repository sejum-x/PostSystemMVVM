using System.IO;
using System.Text.Json;
using PostSystemMVVM.Model;

namespace PostSystemMVVM.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(fileName, jsonString);
        }

        public static DataModel DeserializeData(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<DataModel>(jsonString);
        }
    }
}