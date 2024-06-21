using System;
using System.Collections.Generic;
using System.Linq;

class URI 
{
    static void Main(string[] args)
    {
        int[] entrada = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Dictionary<char,char> dic = new Dictionary<char,char>();
        char[] letras = new char[2];
        char[] frase;

        for(int i =0;i<entrada[0];i++)
        {
            letras = Console.ReadLine().Split().Select(char.Parse).ToArray();
            dic[letras[0]]=letras[1];
        }

        for(int i =0;i<entrada[1];i++)
        {
            frase = Console.ReadLine().Trim().ToCharArray();
            for(int j = 0;j<frase.Length;j++)
            {
                if(dic.ContainsKey(frase[j]))
                {
                    frase[j] = dic[frase[j]];
                }
                else if(dic.ContainsValue(frase[j]))
                {
                    foreach (var x in dic)
                    {
                        if (x.Value == frase[j])
                        {
                            frase[j] = x.Key;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("",frase));
        }
    }
}