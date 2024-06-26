using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class URI 
{
    static void Main(string[] args) 
    {
        string teste;
        string[] frase;
        int soma;
        List<int> print = new List<int>();
        int n;

        while (true)
        {
            teste = Console.ReadLine();
            if (teste == null)
            {
                break;
            }

            frase = teste.Split().ToArray();
            soma = 0;
            n = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                string palavra = frase[i].TrimEnd('.');
                if (EValido(palavra, frase[i]))
                {
                    soma += palavra.Length;
                    n++;
                }
            }

            int media = n > 0 ? soma / n : 0;

            if (media <= 3)
            {
                print.Add(250);
            }
            else if (media <= 5)
            {
                print.Add(500);
            }
            else
            {
                print.Add(1000);
            }
        }

        foreach (int pts in print)
        {
            Console.WriteLine(pts);
        }
    }

    static bool EValido(string palavra, string original)
    {
        if (!Regex.IsMatch(palavra, @"^[a-zA-Z]+$"))
        {
            return false;
        }

        if (original.Length > 0 && original[original.Length - 1] == '.')
        {
            return palavra.Length == original.Length - 1;
        }

        return true;
    }
}
