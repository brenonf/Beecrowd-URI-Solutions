using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a=lista[0];
        int b=lista[1];

        if(a<b)
        {
            a=b-a;
        }
        else if(a>b)
        {
            a= 24-a+b;
        }
        else{a=24;}

        Console.WriteLine($"O JOGO DUROU {a} HORA(S)");
    }
}