using System;
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        var lista = new List<int>();
        var duplicado = new HashSet<int>();
        int[] numeros;

    while(true)
{
    var entrada = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
    if(entrada[0] == 0 && entrada[1] == 0)
        {break;}
    numeros = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
        foreach(int numero in numeros)
        {
            if(lista.Contains(numero))
            {
                duplicado.Add(numero);
            }
            else
            {
                lista.Add(numero);
            }
        }
        Console.WriteLine(duplicado.Count);
        lista.Clear();
        duplicado.Clear();
    }
       
    }
}