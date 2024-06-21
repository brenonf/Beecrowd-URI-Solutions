using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(Math.Abs(n[0]-n[2])+Math.Abs(n[1]-n[3]));
    }
}
