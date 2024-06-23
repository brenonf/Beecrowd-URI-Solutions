using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] lista;
        for(int i=0;i<n;i++)
        {
            lista= Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine
            (
                (lista[0]/3)*(lista[1]/3)
            );
        }
    }
}