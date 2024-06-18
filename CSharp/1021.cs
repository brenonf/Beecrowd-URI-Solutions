using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        double entrada = double.Parse(Console.ReadLine());
        int a = (int)entrada;
        double c = entrada - a;
        c = Math.Round(c, 2);

        int[] nota = { 100, 50, 20, 10, 5, 2 };
        double[] moeda = { 1, 0.5, 0.25, 0.10, 0.05, 0.01 };

        Console.WriteLine("NOTAS:");
        foreach (int i in nota)
        {
            int x = a / i;
            a -= x * i;
            Console.WriteLine($"{x} nota(s) de R$ {i}.00");
        }

        c = a + Math.Round(c, 2);

        Console.WriteLine("MOEDAS:");
        foreach (double i in moeda)
        {
            int x = (int)(Math.Round(c, 2) / Math.Round(i, 2));
            c -= x * i;
            Console.WriteLine($"{x} moeda(s) de R$ {i:F2}");
        }
    }
}
