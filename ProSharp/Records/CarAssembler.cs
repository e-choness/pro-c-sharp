namespace ProSharp.Records;

public class CarAssembler
{
    public static void Assemble()
    {
        Console.WriteLine("=> Assemble a car");
        var car = new Car{ Make = "Honda", Model = "Pilot", Color = "Blue" };
        Console.WriteLine("My car: ");
        DisplayCarStats(car);
        
        Console.WriteLine("=> Assemble another car");
        var anotherCar = new Car { Make = "Lamborghini", Model = "Dah", Color = "Grey" };
        Console.WriteLine("My another car: ");
        DisplayCarStats(anotherCar);
    }

    private static void DisplayCarStats(Car car)
    {
        Console.WriteLine("Car Make: {0}", car.Make);
        Console.WriteLine("Car Model: {0}", car.Model);
        Console.WriteLine("Car Color: {0}", car.Color);
    }
}