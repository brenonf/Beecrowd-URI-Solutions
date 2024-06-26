using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(n);
        Console.WriteLine(Math.Abs(n[3]+n[0]-(n[2]+n[1])));

    }
}