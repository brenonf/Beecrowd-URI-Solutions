using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    { 
        while(true)
        {
            int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(lista[0] == 0 && lista[1]==0)
            {break;}
            Console.WriteLine(lista[0]+lista[1]);
        }
    }
}
