public class HaloGeneric
{
    public void SapaUser<T> (T input)
    {
        Console.WriteLine("Halo User " + input);
    }
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string input = "praktikan";
        halo.SapaUser(input);
    }
}
