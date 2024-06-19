using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>();
        string[] nome;
        int cont=0;
        int n = int.Parse(Console.ReadLine());
        for(int i =0; i<n; i++)
        {
            nome = Console.ReadLine().Split();
            if(nome[0]=="+")
            {cont++;}

            lista.Add(nome[1]);
        }
        lista.Sort();
        foreach(string s in lista)
        {Console.WriteLine(s);}
        Console.WriteLine($"Se comportaram: {cont} | Nao se comportaram: {n-cont}");
    }
}