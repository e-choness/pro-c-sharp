namespace HRAdministrationAPI;

// Generics enables the code to be strongly typed and therefore the code is checked at compile time
public static class FactoryPattern<K,T> where T:class, K, new()
{
    public static K GetInstance()
    {
        K objk;
        objk = new T();
        return objk;
    }
}