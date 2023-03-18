public class HaloGeneric
{
    public void SapaUser()
    {
        string input = "praktikan";
        Console.WriteLine("Halo User " + input);
    }
    public static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();

        haloGeneric.SapaUser();
    }
}
