using System;
using System.Collections.Generic;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cont = 1;
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string s = input[0];
            string r = input[1];

            string w = Win(s, r, cont, "she");
            if (w != "1")
            {
                cont = Contagem(cont);
                continue;
            }

            w = Win(r, s, cont, "raj");
            if (w != "1")
            {
                cont = Contagem(cont);
                continue;
            }

            if (w == "1")
            {
                Console.WriteLine($"Caso #{cont}: De novo!");
            }
            cont = Contagem(cont);
        }
    }

    static int Contagem(int cont)
    {
        cont += 1;
        return cont;
    }

    static string Win(string a, string b, int cont, string quem)
    {
        string w = "1";
        if (a == "tesoura" && b == "papel") w = a;
        if (a == "papel" && b == "pedra") w = a;
        if (a == "pedra" && b == "lagarto") w = a;
        if (a == "lagarto" && b == "Spock") w = a;
        if (a == "Spock" && b == "tesoura") w = a;
        if (a == "tesoura" && b == "lagarto") w = a;
        if (a == "lagarto" && b == "papel") w = a;
        if (a == "papel" && b == "Spock") w = a;
        if (a == "Spock" && b == "pedra") w = a;
        if (a == "pedra" && b == "tesoura") w = a;

        if (w == a)
        {
            if (quem == "she")
            {
                Console.WriteLine($"Caso #{cont}: Bazinga!");
            }
            else if (quem == "raj")
            {
                Console.WriteLine($"Caso #{cont}: Raj trapaceou!");
            }
        }
        return w;
    }
}
