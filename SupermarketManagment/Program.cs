

using SupermarketManagment;
class Program
{
    static void Main(string[] args)
    {
        var supermarket = new Supermarket();
        supermarket.Ime = "Amko";
        supermarket.Lokacija = "Stup";
       

        Console.WriteLine(supermarket.Ime + ' '+ supermarket.Lokacija);
    }
}

