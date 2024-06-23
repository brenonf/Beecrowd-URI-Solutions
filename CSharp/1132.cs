using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int aux;
        int somaTotal=0;
        int inicio13 = 0;
        int fim13 = 0;

        if (x > y)
        {
            aux = y;
            y = x;
            x = aux;
        }

        
        somaTotal = (x + y)*(y-x+1) / 2;

        inicio13 = x % 13 == 0 ? x : x + (13 - x % 13);
        fim13 = y - y % 13;

        if (inicio13 <= y)
        {
            int n13 = (fim13 - inicio13) / 13 + 1;
            int soma13 = n13 * (inicio13 + fim13) / 2;
            somaTotal -= soma13;
        }

        Console.WriteLine(somaTotal);
    }
}
