using System;
using System.Linq;

class URI
{
    static void Main()
    {
       Console.ReadLine();
       int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
       Console.WriteLine(Array.IndexOf(x,x.Min())+1);
    }
}
