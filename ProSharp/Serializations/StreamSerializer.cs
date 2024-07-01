using System.Text;
using System.Text.Json;

namespace ProSharp.Serializations;

public class StreamSerializer
{
    private static IAsyncEnumerable<int> GetNumbers(int n)
    {
        return Enumerable.Range(0, n).ToAsyncEnumerable();
    }

    public static async Task<object> SerializeAsync(int n)
    {
        Console.WriteLine("========> Async Serialization");
        await using var stream = Console.OpenStandardOutput();
        var data = new { Data = GetNumbers(n) };
        await JsonSerializer.SerializeAsync(stream, data);
        Console.WriteLine();
        return data;
    }

    public static async Task DeserializeAsync()
    {
        Console.WriteLine("========> Async Deserialization");
        var stream = new MemoryStream("[0,1,2,3,4]"u8.ToArray());
        await foreach (var item in JsonSerializer.DeserializeAsyncEnumerable<int>(stream))
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    public static void NativeListTest()
    {
        
    }
}