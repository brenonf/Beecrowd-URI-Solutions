using System;
using System.Linq;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {   
            CultureInfo.DefaultThreadCurrentCulture =new CultureInfo("en-US");
            decimal[] lista = new decimal[5] { 4m, 4.5m, 5m, 2m, 1.5m };
            int[] pedido = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine($"Total: R$ {lista[pedido[0] - 1] * pedido[1]:F2}");

        
        }
    }
}