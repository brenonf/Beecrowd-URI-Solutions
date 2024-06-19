using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] lua = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = lua[0];
        int b = lua[1];

        if(b>=0 && b<=2)
        {
            Console.WriteLine("nova");
        }
        else if(b>=3 && b<=96 & b>a)
        {
            Console.WriteLine("crescente");
        }
        else if(b>=97 && b<=100)
        {
            Console.WriteLine("cheia");
        }
        else if(b>=3 && b<=96 & b<a)
        {
            Console.WriteLine("minguante");
        }

    }
}