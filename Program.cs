<<<<<<< HEAD
﻿public class HaloGeneric
{
    public void SapaUser<T> (T input)
    {
        Console.WriteLine("Halo User " + input);
    }
}
=======
﻿public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    } 
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string input = "praktikan";
        halo.SapaUser(input);
    
        DataGeneric<int> data = new DataGeneric<int>(1302210104);
        data.printData();
        
    }
}
>>>>>>> generic-class
