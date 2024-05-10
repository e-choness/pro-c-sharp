namespace ProSharp.DateTimes;

public class TimeSpans
{
    public static void UseDatesAndTimes()
    {
        Console.WriteLine("=> Dates and Times:");
        DateTime dt = new(2015, 10, 17);
        Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

        dt = dt.AddMonths(2);
        Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

        TimeSpan ts = new(4, 30, 0);
        Console.WriteLine("Time spam is: {0}", ts);
        Console.WriteLine($"Subtracted time spam is: {ts.Subtract(new TimeSpan(0, 15, 0))}");
    }

    public static void UseDateTimeOnly()
    {
        Console.WriteLine("=> Dates and Times:");

        DateOnly d = new(2021, 07, 21);
        Console.WriteLine("Date only: {0}", d);

        TimeOnly t = new(13, 30, 09, 99);
        Console.WriteLine("Time only: {0}", t);
    }
}