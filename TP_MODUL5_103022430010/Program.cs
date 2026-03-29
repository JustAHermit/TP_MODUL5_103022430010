public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T inputData)
    {
        data = inputData;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main()
    {
        string perusahaan = "Limbus Company";

        DataGeneric<string> dataperusahaan = new DataGeneric<string>(perusahaan);
        dataperusahaan.PrintData();
    }
}