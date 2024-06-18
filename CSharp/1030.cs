using System;
using System.Linq;
using System.Collections.Generic;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                int[] lista;
                List<int> roda = new List<int>();
                int indice;

                lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
                indice = lista[0] - 1;
                for (int i = 1; i <= lista[0]; i++)
                { roda.Add(i); }

                while (roda.Count > 1)
                {
                    indice += lista[1];
                    if (indice + 1 > roda.Count)
                    {
                        indice = indice % roda.Count;
                    }

                    
                    if (roda.Count == lista[0])
                    { lista[1] -= 1; }
                    roda.RemoveAt(indice);

                }
                Console.WriteLine($"Case {j+1}: {roda[0]}");
            }



        }
    }
}