using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] y = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine((x[0]/x[1])*y[1]+x[0]*y[0]);
    }
}