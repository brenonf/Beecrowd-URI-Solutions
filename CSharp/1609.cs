using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] listao;
        for(int i = 0; i < n;i++)
        {
            Console.ReadLine();
            listao = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(listao.Distinct().Count());
        }
    }
}