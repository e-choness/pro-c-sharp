namespace SomeCSharpPractice;

public class GenericArray
{
    public static void DisplayArrays()
    {
        int[] ints = new[]{ 1, 2, 3 };
        double[] doubles = new[] { 4.5, 6.7, 8.9 };
        String[] strings = new[] { "a", "b", "c" };
        DisplayElements(ints);
        DisplayElements(doubles);
        DisplayElements(strings);
    }   
    
    private static void DisplayElements<Thing>(Thing[] array){
        foreach (var element in array)
        {
            // ReSharper disable once HeapView.PossibleBoxingAllocation
            Console.Write(element + " ");
        } 
        Console.WriteLine();
    }
}

