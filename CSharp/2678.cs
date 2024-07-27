using System;
using System.Collections.Generic;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        string x;
        StringBuilder print = new StringBuilder();

        Dictionary<char, object> dic = new Dictionary<char, object>
        {
            { 'a', 2 }, { 'b', 2 }, { 'c', 2 },
            { 'd', 3 }, { 'e', 3 }, { 'f', 3 },
            { 'g', 4 }, { 'h', 4 }, { 'i', 4 },
            { 'j', 5 }, { 'k', 5 }, { 'l', 5 },
            { 'm', 6 }, { 'n', 6 }, { 'o', 6 },
            { 'p', 7 }, { 'q', 7 }, { 'r', 7 }, { 's', 7 },
            { 't', 8 }, { 'u', 8 }, { 'v', 8 },
            { 'w', 9 }, { 'x', 9 }, { 'y', 9 }, { 'z', 9 },
            { '#', '#' }, { '*', '*' }
        };

        while (true)
        {
            x = Console.ReadLine();
            if (string.IsNullOrEmpty(x))
            {
                break;
            }

            x = x.ToLower();

            foreach (char c in x)
            {
                if (Char.IsDigit(c))
                {
                    print.Append(c);
                }
                else if (dic.ContainsKey(c))
                {
                    print.Append(dic[c]);
                }
            }

            Console.WriteLine(print);
            print.Clear();
        }
    }
}
