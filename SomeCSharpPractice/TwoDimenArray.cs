namespace SomeCSharpPractice;

public class TwoDimenArray
{
    private String[,] _parkingLot = { { "Car1", "Car2", "Car3" }, { "Car4", "Car5", "Car6" }, { "Car7", "Car8", "Car9" } };

    public TwoDimenArray()
    { 
        OutputCars();
    }

    private void OutputCars()
    {
        string output = "";

        foreach (var cars in _parkingLot)
        {
            output += cars + "\n";
        }
        Console.WriteLine(output);
        
        // Output the array like a grid
        output = "";
        for (int i = 0; i < _parkingLot.GetLength(0); i++)
        {
            for (int j = 0; j < _parkingLot.GetLength(1); j++)
            {
                output += _parkingLot[i, j] + " ";
            }
            output += "\n";
        }
        Console.WriteLine(output);
    }
}