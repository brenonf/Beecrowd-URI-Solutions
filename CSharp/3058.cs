using System; 
using System.Linq;
using System.Globalization;

class URI {

    static void Main(string[] args) 
    { 
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int n = int.Parse(Console.ReadLine());
        decimal[] precos;
        decimal  menor=9999999;
        for(int i =0;i<n;i++)
        {
            precos = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            if((decimal)(precos[0]*1000)/precos[1]<menor)
            {menor=(decimal)(precos[0]*1000)/precos[1];}
        }
        Console.WriteLine($"{menor:F2}");
    }

}