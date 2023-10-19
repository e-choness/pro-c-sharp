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

    // public async DisplayResultAlt()
    // {
    //     await GetUserAsync()
    // }

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

    /*
     * If the work you have is I/O-bound, use async and await without Task.Run.
     * You should not use the Task Parallel Library.
     * If the work you have is CPU-bound and you care about responsiveness,
     * use async and await, but spawn off the work on another thread with Task.Run.
     * If the work is appropriate for concurrency and parallelism,
     * also consider using the Task Parallel Library.
     */

    class User
    {
        public int Id { get; set; }
    }
    private static async Task<User> GetUserAsync(int userId)
    {
        return await Task.FromResult(new User() { Id = userId });
    }

    private static async Task<IEnumerable<User>> GetUserAsync(IEnumerable<int> userIds)
    {
        var getUserTasks = new List<Task<User>>();
        foreach (var userId in userIds)
        {
            getUserTasks.Add(GetUserAsync(userId));
        }

        return await Task.WhenAll(getUserTasks);
    }
}

