using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int Sn =((1+n)*n)/2;
        int Sn2 =lista.Sum();
        Console.WriteLine(Sn-Sn2);
    }
}

/*outra solução seria por força bruta,
ordenando a array,
varrendo tudo com for 1 a 1,
se encontrou um numero i != da lista,
então break e encontrou o numero que faltava.*/