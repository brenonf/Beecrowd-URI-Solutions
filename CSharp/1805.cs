using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();


        long soma = (x[1] * (x[1] + 1)) / 2 - ((x[0] - 1) * x[0]) / 2;
        
        Console.WriteLine(soma);
    }
}
