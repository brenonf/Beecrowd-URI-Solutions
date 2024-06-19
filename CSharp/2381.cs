using System;
using System.Linq;

class Program 
{
    static void Main() 
    {
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] lista = new string[x[0]];
        for(int i =0;i<x[0];i++)
        {
            lista[i] = Console.ReadLine();
        }
        Array.Sort(lista);
        Console.WriteLine(lista[x[1]-1]);
    }
        
}