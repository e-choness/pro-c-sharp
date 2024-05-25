using System.Collections;

namespace ProSharp.LINQ;

public class TypeFilter
{
    public static void Filter()
    {
        Console.WriteLine("=> Show Type filter");
        
        var stuff = new ArrayList();
        stuff.AddRange(new object[]{10, 400, 8, false, new float(), "string data"});
        
        var ints = stuff.OfType<int>();
        var result = string.Join(" ", ints.Select(i=>i.ToString()));
        
        Console.WriteLine("Ints in the array list: {0}", result);
    }
    
    
}