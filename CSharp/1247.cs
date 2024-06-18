using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string nn = Console.ReadLine();
            if(nn == null)
            {
                break;
            }

            int[] n = nn.Split().Select(int.Parse).ToArray();
            double d = Math.Sqrt(Math.Pow(12, 2) + Math.Pow(n[0], 2));

            // Cálculo do tempo para o policial e para a vitima da sociedade
            double tempoPolicial = d / n[2];
            double tempoBandido = 12.0 / n[1];

            // Condição de comparação corrigida
            if(tempoPolicial <= tempoBandido)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
