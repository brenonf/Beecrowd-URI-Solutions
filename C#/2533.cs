using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        CultureInfo culture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = culture;
        while(true)
        {
        string nn = Console.ReadLine();
        if(nn==null)
        {break;}
        int n = int.Parse(nn);
        float soma = 0;
        int horas = 0;

        for (int i = 0; i < n; i++)
        {
            string[] teste = Console.ReadLine().Split();
            soma += int.Parse(teste[0]) * int.Parse(teste[1]);
            horas += int.Parse(teste[1]);
        }

        Console.WriteLine("{0:F4}", soma / (100 * horas));
        }
    }
}
