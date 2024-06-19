using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] lava = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] seca = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if(n>= lava[0] && n<=lava[1] && n>=seca[0] && n<=seca[1])
        {
            Console.WriteLine("possivel");
        }
        else{Console.WriteLine("impossivel");}

    }
}