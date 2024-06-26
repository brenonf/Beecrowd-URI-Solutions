using System; 
using System.Linq;
using System.Collections.Generic;

class URI 
{

    static void Main(string[] args) 
    {
        string nome;
        List<string> lista = new List<string>();

        while(true)
        {
            nome = Console.ReadLine();
            if(string.IsNullOrEmpty(nome))
            {break;}
            lista.Add(nome);

        }
        lista.Sort(StringComparer.OrdinalIgnoreCase);
        lista.Reverse();

        Console.WriteLine(lista[0]);

    }
}