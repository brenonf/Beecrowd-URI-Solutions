using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int cont=0;
        int segundos=0;

        while(segundos<n[1])
        {
            segundos+= n[1]-n[0];
            cont++;
        }
        Console.WriteLine(cont);
    }
}