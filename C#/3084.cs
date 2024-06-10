using System;
using System.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string x = Console.ReadLine();
                if (x == null)
                {
                    break;
                }
                string[] input = x.Split();

               

                double[] y = input.Select(double.Parse).ToArray();
                double h = (y[0] / 360) * 12;
                double m = (y[1] / 360) * 60;

                Console.WriteLine($"{h:00}:{m:00}");
            }
        }
    }
}
