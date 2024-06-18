using System;
using System.Globalization;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,decimal> cesta = new Dictionary<string, decimal>();
        string[] nome;
        int m;
        decimal soma=0;

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n;i++)
        {
            m=int.Parse(Console.ReadLine());
            for(int j = 0; j < m;j++)
            {
                nome =Console.ReadLine().Split();
                cesta[nome[0]]= decimal.Parse(nome[1], CultureInfo.InvariantCulture);
            }
            m=int.Parse(Console.ReadLine());
            for(int j = 0; j < m;j++)
            {
                nome=Console.ReadLine().Split();
                soma += cesta[nome[0]]*int.Parse(nome[1], CultureInfo.InvariantCulture);
            }
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "R$ {0:0.00}", soma));

            soma=0;
            cesta.Clear();

        }
        
    }
}