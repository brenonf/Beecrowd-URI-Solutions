using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int n = int.Parse(Console.ReadLine());
        int[] notas =Console.ReadLine().Split().Select(int.Parse).ToArray();

        for(int i = 0; i < n;i++)
        {
            if(dic.ContainsKey(notas[i]))
            {
                dic[notas[i]]++;
            }
            else
            {
                dic[notas[i]] = 1;
            }
        }
        Console.WriteLine(dic.OrderBy(x=>x.Value).ThenBy(x=>x.Key).Last().Key);

    }
}
