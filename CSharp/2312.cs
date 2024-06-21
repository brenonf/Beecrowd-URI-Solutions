using System;
using System.Collections.Generic;
using System.Linq;
class Pais
{
    public string Nome { get; set; }
    public int Ouro { get; set; }
    public int Prata { get; set; }
    public int Bronze { get; set; }

    public Pais(string nome, int ouro , int prata , int bronze )
    {
        Nome = nome;
        Ouro = ouro;
        Prata = prata;
        Bronze = bronze;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());

        List<Pais> paises = new List<Pais>();
        for (int i = 0; i < n; i++)
        {
            string[] dados = Console.ReadLine().Split();
            string nome = dados[0];
            int ouro = int.Parse(dados[1]);
            int prata = int.Parse(dados[2]);
            int bronze = int.Parse(dados[3]);

            paises.Add(new Pais(nome, ouro, prata, bronze));
        }

        var paisesOrdenados = paises.OrderByDescending(p => p.Ouro).ThenByDescending(p => p.Prata).ThenByDescending(p => p.Bronze).ThenBy(p => p.Nome).ToList();






        foreach (var pais in paisesOrdenados)
        {
            Console.WriteLine($"{pais.Nome} {pais.Ouro} {pais.Prata} {pais.Bronze}");
        }
    }
}

// entender pq não ordena na parte do nome
