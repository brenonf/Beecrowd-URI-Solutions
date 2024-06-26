using System;
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        string[] nomes = new string[n];

        for (int i = 0; i < n; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        var listao = nomes.OrderBy(nome => nome[0]).ThenBy(nome => Array.IndexOf(nomes, nome));

        foreach (string nome in listao)
        {
            Console.WriteLine(nome);
        }
    }
}
