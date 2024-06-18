using System;
using System.Linq;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = lista[0];
            int y = lista[1];

            if(x>y)
            { 
                if(x%y==0) { Console.WriteLine("Sao Multiplos"); }
                else { Console.WriteLine("Nao sao Multiplos"); }
            }
            else 
            {
                if (y % x == 0) { Console.WriteLine("Sao Multiplos"); }
                else { Console.WriteLine("Nao sao Multiplos"); }
            }


        }
    }
}