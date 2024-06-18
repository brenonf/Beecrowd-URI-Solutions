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
            decimal[] ponto = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal x = ponto[0];
            decimal y = ponto[1];

            if(x >0 && y >0) { Console.WriteLine("Q1"); }
            else if(x <0 && y <0) { Console.WriteLine("Q3"); }
            else if(x>0 && y<0){ Console.WriteLine("Q4"); }
            else if(x<0 && y > 0) { Console.WriteLine("Q2"); }
            else if(x==0 && y!=0) { Console.WriteLine("Eixo Y"); }
            else if (y == 0 && x!=0) { Console.WriteLine("Eixo X"); }
            else { Console.WriteLine("Origem"); }


        }
    }
}