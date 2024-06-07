namespace ProSharp.Serializations;

public class View
{
    public void Showcase()
    {
        Console.WriteLine("========> Fun With Object Serialization\n");
        
        var myCars = ObjectFactory.GetJamesBondCars();
        var person = ObjectFactory.GetPerson("James", true);
        
        
    }
}