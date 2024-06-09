namespace ProSharp.Serializations;

public class View
{
    public static void Showcase()
    {
        Console.WriteLine("========> Fun With Object Serialization\n");
        
        var myCars = ObjectFactory.GetJamesBondCars();
        var person = ObjectFactory.GetPerson("James", true);
        
        Console.WriteLine("=========> My cars' data saved.");
        FileHander<List<JamesBondCar>>.SaveAsJsonFormat(myCars, "CarData.json", true);
        
        Console.WriteLine("=========> The person data saved.");
        FileHander<Person>.SaveAsJsonFormat(person, "PersonData.json", true);
    }
}