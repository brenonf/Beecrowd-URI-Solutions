using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main()
    {
        List<int> par = new List<int>();
        List<int> impar = new List<int>();

        for (int i = 0; i < 15; i++)
        {
            int x = int.Parse(Console.ReadLine());
            (x % 2 == 0 ? par : impar).Add(x);

            if (par.Count == 5)
            {
                Print(par, "par");
                par.Clear();
            }
            if (impar.Count == 5)
            {
                Print(impar, "impar");
                impar.Clear();
            }
        }
        if (impar.Count > 0)
        {
            Print(impar, "impar");
        }
        if (par.Count > 0)
        {
            Print(par, "par");
        }
    }

    private static void Print(List<int> lista, string n)
    {
        for (int j = 0; j < lista.Count; j++)
        {
            Console.WriteLine($"{n}[{j}] = {lista[j]}");
        }
    }
}
