namespace ProSharp.Serializations;

public class View
{
    public static void Showcase()
    {
        Console.WriteLine("========> Fun With Object Serialization\n");
        
        var myCars = ObjectFactory.GetJamesBondCars();
        var person = ObjectFactory.GetPerson("James", true);
        
        Console.WriteLine("=========> My cars' data saved.");
        var fileHandler = new FileHandler<List<JamesBondCar>>();
        fileHandler.SaveAsJsonFormat(myCars, "CarData.json", true);
        
        Console.WriteLine("=========> The person data saved.");
        var fileHandler2 = new FileHandler<Person>();
        fileHandler2.SaveAsJsonFormat(person, "PersonData.json", true);
    }
}