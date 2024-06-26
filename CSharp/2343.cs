using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        string[] listao = new string[n];
        HashSet<string> hash = new HashSet<string>();
        bool flag = false;

        for (int i = 0; i < n; i++)
        {
            listao[i] = Console.ReadLine();
            if (hash.Contains(listao[i]))
            {
                flag = true;
                break;
            }
            else
            {
                hash.Add(listao[i]);
            }
        }
        Console.WriteLine(flag ? 1 : 0);
    }
}
