using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    { 
        int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] lista2 = lista.ToArray();
        Array.Sort(lista2);

        if (lista.SequenceEqual(lista2))
        {
            Console.WriteLine("C");
        }
        else if (lista.SequenceEqual(lista2.Reverse()))
        {
            Console.WriteLine("D");
        }
        else
        {Console.WriteLine("N");}
    }
}
