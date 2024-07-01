using System.IO.Abstractions;
using System.Text.Json;

namespace ProSharp.Serializations;

public class FileHandler<T> where T : new()
{
    readonly IFileSystem _fileSystem;
    
    // <summary>Create MyComponent with the given fileSystem implementation</summary>
    public FileHandler(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
    }
    
    /// <summary>Create MyComponent</summary>
    public FileHandler() : this(
        fileSystem: new FileSystem() //use default implementation which calls System.IO
    )
    {
    }
    public void SaveAsJsonFormat(T objGraph, string fileName, bool includeOptions = false)
    {
        
        if (includeOptions)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };
            _fileSystem.File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph, options));
        }
        else
        {
            _fileSystem.File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph));
        }
    }

    public T? Load(string fileName)
    {
        T? obj = new T();
        var jsonString = _fileSystem.File.ReadAllText(fileName);
        
        if (!string.IsNullOrEmpty(jsonString))
        {
            obj = JsonSerializer.Deserialize<T>(jsonString);
        }

        return obj;
    }
}