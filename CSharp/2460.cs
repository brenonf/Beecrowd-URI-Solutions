using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        Console.ReadLine(); 
        List<int> fila = Console.ReadLine().Split().Select(int.Parse).ToList();

        Console.ReadLine();

        HashSet<int> desistentes = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));

        fila.RemoveAll(x => desistentes.Contains(x));

        Console.WriteLine(string.Join(" ", fila));
    }
}
