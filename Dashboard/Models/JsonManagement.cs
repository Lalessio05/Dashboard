using System.IO;
using static Newtonsoft.Json.JsonConvert;
namespace Dashboard.Models
{
    class JsonManagement : IDataManagement
    {
        static public ICollection<T> ReadCollection<T>(string filePath)
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
            return DeserializeObject<ICollection<T>>(File.ReadAllText(filePath)) ?? new List<T>();
        }

        static public void WriteCollection<T>(string filePath,ICollection<T> collection)
        {
            File.WriteAllText(filePath, collection.Aggregate(string.Empty, (x, y) => x += $"{y}\r\n"));   
        }

    }
}
