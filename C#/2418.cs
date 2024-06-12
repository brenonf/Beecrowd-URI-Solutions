using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
     decimal[] lista = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
     Array.Sort(lista);
     lista[0]=0.0m;
     lista[4]=0.0m;
     Console.WriteLine($"{lista.Sum():F1}");
     

    }

    
}
