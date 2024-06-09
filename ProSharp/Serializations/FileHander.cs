using System.Text.Json;

namespace ProSharp.Serializations;

public class FileHander<T>
{
    public static void SaveAsJsonFormat(T objGraph, string fileName, bool includeOptions = false)
    {
        
        if (includeOptions)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };
            File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph, options));
        }
        else
        {
            File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph));
        }
        
        
        
    }
}