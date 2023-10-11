namespace SomeCSharpPractice;


public class AsyncFunctions
{
    private const int Second = 1000;  
    public void DisplayResult()
    {
        CountToTenAsync();
        WaitForASecond();
        WaitForNSecond(10);
    }

    async void CountToTenAsync()
    {
        Console.WriteLine("Let's start counting.");
        for (var i = 0; i != 10; i++)
        {
            Console.WriteLine($"The magic number is {i}.");
            // Wait for a frame (in Unity), will be terminated early when the main thread ends.
            await Task.Yield(); 
        }
        Console.WriteLine("Finally Done.");
    }

    async void WaitForASecond()
    {
        Console.WriteLine("Give me a second...");
        await Task.Delay(Second);
        Console.WriteLine("Alright, I'm done...");
    }

    async void WaitForNSecond(int n)
    {
        Console.WriteLine($"Give me another {n} seconds.");
        await Task.Delay(n * Second);
        Console.WriteLine("Ok, we are good to go.");
    }
}

