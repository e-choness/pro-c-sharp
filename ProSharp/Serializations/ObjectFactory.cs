namespace ProSharp.Serializations;

public class ObjectFactory
{
    private static List<double> GetPresets()
    {
        return new List<double> { 89.3, 105.1, 97.1 };
    }
    private static Radio GetRadio()
    {
        return new Radio
        {
            StationPresets = GetPresets(),
            HasTweeters = true
        };
    }

    private static JamesBondCar GetJamesBondCar(bool canFly, bool canSubmerge)
    {
        return new JamesBondCar
        {
            CanFly = canFly,
            CamSubmerge = canSubmerge,
            TheRadio = GetRadio()
        };
    }

    public static List<JamesBondCar> GetJamesBondCars()
    {
        return
            new List<JamesBondCar>
            {
                GetJamesBondCar(true, true),
                GetJamesBondCar(true, false),
                GetJamesBondCar(false, true),
                GetJamesBondCar(false, false)
            };
    }

    public static Person GetPerson(string firstName, bool isAlive)
    {
        return new Person { FirstName = firstName, IsAlive = isAlive };
    }
}