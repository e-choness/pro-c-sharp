using System.Net.Mime;
using System.Xml.Linq;

namespace SomeCSharpPractice;

public class XmlStuff
{
    public static void GetResult()
    {
        ReadXml();
    }
    
    private static void ReadXml()
    {
        var content = XElement.Load(@"D:\projects\advanced-csharp-practice\SomeCSharpPractice\example.xml");
        var filteredContent = new XElement("example",
            from element in content.Elements()
            where (int)element is 'Wood'
            select element);
        
        Console.WriteLine(filteredContent);
    }
}