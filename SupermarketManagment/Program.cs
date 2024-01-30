using SupermarketManagment;

class Program
{
    static void Main(string[] args)
    {
        var supermarket = new Supermarket("Amko", "Patriotske lige bb");

        Console.WriteLine(supermarket.Ime + ' '+ supermarket.Lokacija);
    }
}

