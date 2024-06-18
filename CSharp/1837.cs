using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int a = n[0];
        int b = n[1];

        int q = a / b; 
        int r = a % b; 

                if (r < 0)
        {
            r += Math.Abs(b);
            q -= Math.Sign(b);
        }

        Console.WriteLine($"{q} {r}");
    }
}
