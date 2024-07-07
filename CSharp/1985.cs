using System;
using System.Collections.Generic;

class URI
{
    static void Main()
    {
        Console.WriteLine("{0:F2}", Preco(Entrada()));
    }

    static List<List<string>> Entrada()
    {
        int n = int.Parse(Console.ReadLine());
        var x = new List<List<string>>();
        
        for (int i = 0; i < n; i++)
        {
            var a = new List<string>(Console.ReadLine().Split());
            x.Add(a);
        }

        return x;
    }

    static double Preco(List<List<string>> x)
    {
        double comanda = 0;
        
        foreach (var item in x)
        {
            string codigo = item[0];
            int quantidade = int.Parse(item[1]);

            switch (codigo)
            {
                case "1001":
                    comanda += quantidade * 1.50;
                    break;
                case "1002":
                    comanda += quantidade * 2.50;
                    break;
                case "1003":
                    comanda += quantidade * 3.50;
                    break;
                case "1004":
                    comanda += quantidade * 4.50;
                    break;
                case "1005":
                    comanda += quantidade * 5.50;
                    break;
            }
        }

        return comanda;
    }
}



/*

Pode ser necessário ajustar a cultura para que imprima corretamente com "." em sua máquina:

using System.Globalization;

...

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
*/