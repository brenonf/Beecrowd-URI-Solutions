using System;
using System.Linq;

class Program 
{
    static void Main() 
    {
        int[] lista;
        int n;
        int indice;

        while(true)
        {
            n= int.Parse(Console.ReadLine());
            if(n == 0)
            {break;}

            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            lista[Array.IndexOf(lista,lista.Max())]=0;
            Console.WriteLine(Array.IndexOf(lista,lista.Max())+1);
        }
    }
}