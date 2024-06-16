using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"{x*y/12m:F3}");

    }

}