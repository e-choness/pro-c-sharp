namespace ProSharp.Lambda;

public class Expressions
{
    public static int Add(int x, int y) => x + y;

    public static int AddWrapper(int x, int y)
    {
        return AddNumbers();

        int AddNumbers() => x + y;
    }
}