using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x;
        SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (dic.ContainsKey(x))
            {
                dic[x]++;
            }
            else
            {
                dic[x] = 1;
            }

        }
        foreach (var p in dic)
        {
            Console.WriteLine($"{p.Key} aparece {p.Value} vez(es)");
        }
    }
}
