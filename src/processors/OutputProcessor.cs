using System.IO;
using Newtonsoft.Json;

namespace clothInfoGen.processors
{
    public class OutputProcessor
    {

        public static void Process()
        {
            Process("output/clothData.json", Main.Storage.pedData);
        }
        
        public static void Process(string pathExtend, object data, JsonSerializerSettings settings = null)
        {
            string path = Main.GetPath(pathExtend, true);
            
            string result = JsonConvert.SerializeObject(data, settings);
            File.WriteAllText(path, result);

        }
        
    }
}