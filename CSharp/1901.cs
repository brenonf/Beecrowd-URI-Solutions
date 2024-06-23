using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[][] floresta = new int[n][];
        int[] celula;
        HashSet<int> listao = new HashSet<int>();

        for(int i=0;i<n;i++)
        {
            floresta[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        for(int i=0;i<n*2;i++)
        {
            celula = Console.ReadLine().Split().Select(int.Parse).ToArray();
            listao.Add(floresta[celula[0]-1][celula[1]-1]);
        }
        Console.WriteLine(listao.Count());
    }
}

