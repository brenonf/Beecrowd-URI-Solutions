using System;
using System.Globalization;
using System.Linq;

class URI {
    static void Main(string[] args) {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        
        decimal[] a = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        decimal[] b = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

        
        Console.WriteLine($"VALOR A PAGAR: R$ {a[1]*a[2]+b[1]*b[2]:F2}");
    }
}
