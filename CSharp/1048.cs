using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal salario = decimal.Parse(Console.ReadLine());
        int percent=0;

        if(salario <=400)
        {percent =15;}
        else if(salario>400.01m && salario <=800.00m)
        {percent =12;}
        else if(salario >=800.01m && salario<=1200.00m)
        {percent = 10;}
        else if(salario>=1200.01m && salario<=2000.00m)
        {percent = 7;}
        else
        {
            percent=4;
        }

        Console.WriteLine($"Novo salario: {salario*(1+percent/100m):F2}");
        Console.WriteLine($"Reajuste ganho: {salario*(percent/100m):F2}");
        Console.WriteLine($"Em percentual: {percent} %");
        
    }
}