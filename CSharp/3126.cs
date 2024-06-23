using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).ToArray().Sum());
    }
}