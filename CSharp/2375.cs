using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int n =int.Parse(Console.ReadLine());
        int[] m = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if(n<=m[0] && n<=m[1] && n<=m[2] )
        {
            Console.WriteLine("S");
        }
        else
        {Console.WriteLine("N");}
    }
}