using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            double x = double.Parse(Console.ReadLine());

            if(x>=0d && x<=25.0d)
            { 
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(x>25d && x<=50d)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(x>50d && x<=75d)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if(x>75d &&x<=100d)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else { Console.WriteLine("Fora de intervalo"); }

        
        }
    }
}