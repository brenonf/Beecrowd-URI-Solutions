using System;

class URI
{
    static void Main()
    {
        int contgrenais = 0;
        int contgremio = 0;
        int continter = 0;
        int contempate = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            int i = int.Parse(input[0]);
            int g = int.Parse(input[1]);

            if (i > g)
            {
                continter++;
            }
            else if (g > i)
            {
                contgremio++;
            }
            else
            {
                contempate++;
            }

            contgrenais++;
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            string resposta = Console.ReadLine();

            if (resposta == "2")
            {
                break;
            }
        }

        Console.WriteLine($"{contgrenais} grenais");
        Console.WriteLine($"Inter:{continter}");
        Console.WriteLine($"Gremio:{contgremio}");
        Console.WriteLine($"Empates:{contempate}");

        if (contgremio > continter)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else if (continter > contgremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}
