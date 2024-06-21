using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {   
       int[] n = Console.ReadLine().Split().Select(int.Parse).OrderBy(x=>x).ToArray();
        Console.WriteLine(n[1]);
    }
}