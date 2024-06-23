using System;
using System.Linq;
using System.Collections.Generic;
class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int cont=1;
        List<int> maiores = new List<int>();

        int[] listao = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for(int i =0;i<n-1;i++)
        {
            if(listao[i] == listao[i+1])
            {
                cont++;
            }
            else
            {
                maiores.Add(cont);
                cont=1;
            }
        }
        maiores.Add(cont);
        Console.WriteLine(maiores.Max());

    }
}