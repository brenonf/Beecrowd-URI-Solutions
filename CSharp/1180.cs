using System;
using System.Linq;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        int[] x = Console.ReadLine().Trim().Replace("  "," ").Split().Select(int.Parse).ToArray(); 
        int min = x.Min();
        int indice = Array.IndexOf(x, min);

        Console.WriteLine($"Menor valor: {min}");
        Console.WriteLine($"Posicao: {indice}");
    }
}
