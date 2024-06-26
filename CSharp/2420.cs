using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] listao = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int somaTotal = listao.Sum();
        int soma = 0;

        for (int i=0; i < n; i++)
        {
            soma += listao[i];
            if (soma == somaTotal / 2)
            {
                Console.WriteLine(i + 1); 
                break;
            }
        }
    }
}
