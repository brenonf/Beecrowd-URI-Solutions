using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if(n[0] >=0 && n[0]<=432 && n[1]>=0 && n[1]<=468)
        {
            Console.WriteLine("dentro");
        }
        else
        {
            Console.WriteLine("fora");
        }
    }
}