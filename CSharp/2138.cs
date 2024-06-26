using System;
using System.Collections.Generic;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        string n;
        char[] lista;
        Dictionary<char, int> dict = new Dictionary<char, int>();

        while (true)
        {
            n = Console.ReadLine();
            if (string.IsNullOrEmpty(n))
            {
                break;
            }

            dict.Clear(); 

            lista = n.ToCharArray();
            foreach (char c in lista)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            char chave = dict.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).First().Key;
            Console.WriteLine(chave);
        }
    }
}
