using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int altura;
            int largura;

            int passadas = 0;
            int comparacao = 0;

            string[] entrada = Console.ReadLine().Split();
            altura = int.Parse(entrada[0]);
            largura = int.Parse(entrada[1]);

            if (altura == 0 && largura == 0)
            {
                break;
            }

            string[] medidas = Console.ReadLine().Split();
            for (int i = 0; i < largura; i++)
            {
                int xi = int.Parse(medidas[i]);

                if (i == 0)
                {
                    passadas += altura - xi;
                }
                else if (xi < comparacao)
                {
                    passadas += comparacao - xi;
                }
                comparacao = xi;
            }

            Console.WriteLine(passadas);
        }
    }
}
