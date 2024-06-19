using System;
using System.Linq;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int n = int.Parse(Console.ReadLine());
        
        decimal valor;
        decimal kg=0m;
        decimal custo=0m;
        string[] compra;

        for(int i=0;i<n;i++)
        {
            valor = decimal.Parse(Console.ReadLine());
            compra =Console.ReadLine().Split();
            kg+= compra.Length;
            custo+=valor;
            Console.WriteLine($"day {i+1}: {compra.Length} kg");
        }
        kg=(decimal)kg/n;
        custo=(decimal)custo/n;
        Console.WriteLine($"{kg:F2} kg by day");
        Console.WriteLine($"R$ {custo:F2} by day");
        
    }
}