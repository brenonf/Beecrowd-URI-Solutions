using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] lista1;
        int[] lista2;
        int item=0;
        int valor =99999999;


        for(int i = 0; i < n;i++)
        {
            lista1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            lista2 =  Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int j = 0; j < lista2.Length;j++)
            {
                if(Math.Abs(lista2[j]-lista1[1])<valor)
                {
                    item = j;
                    valor=Math.Abs(lista2[j]-lista1[1]);
                }
            }
            Console.WriteLine(item+1);
            item=0;
            valor=9999999;
        }
    }
}