using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split();
        long n = long.Parse(inputs[0]);
        long[] numeros = Console.ReadLine().Split().Select(long.Parse).ToArray();
        HashSet<long> estrelas = new HashSet<long>();

        long lugar = 0;
        bool par = false;

        if (numeros[0] % 2 == 0)
        {
            Console.WriteLine($"{1} {(numeros.Sum() <= 0 ? 0 : numeros.Sum() - 1)}");
        }
        else
        {
            while (true)
            {
                estrelas.Add(lugar + 1);
                if (numeros[lugar] > 0)
                {
                    par = numeros[lugar] % 2 == 0;
                    numeros[lugar] -= 1;
                }
                else
                {
                    par = true;
                }

                if (par)
                {
                    lugar -= 1;
                }
                else
                {
                    lugar += 1;
                }

                if (lugar < 0 || lugar >= n)
                {
                    break;
                }
            }

            long soma = numeros.Sum(x => (long)x);

            Console.WriteLine($"{estrelas.Count} {soma}");
        }
    }
}
