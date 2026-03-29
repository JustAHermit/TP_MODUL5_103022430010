public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

class Program
{
    static void Main()
    {
        String nama = "Arsal";
        HaloGeneric hg = new HaloGeneric();
        hg.SapaUser(nama);
    }
}