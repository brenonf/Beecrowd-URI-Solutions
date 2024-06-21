using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> pontos = new List<int>();
        for(int i=0;i<n[0];i++)
        {pontos.Add(0);}
        int[] listao = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for(int i =0;i<n[1];i++)
        {
            for(int j =0;j<n[0];j++)
            {
                pontos[j]+=listao[j+i*n[0]];
            }
        }
        Console.WriteLine(pontos.LastIndexOf(pontos.Max())+1);
    }
}