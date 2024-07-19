using System;
using System.Collections.Generic;

class URI
{
    public class TrieNode
    {
        public Dictionary<char,TrieNode> Children{ get; }=new Dictionary<char, TrieNode>();
        public bool fim { get; set; }
    }

    static void Main(string[] args)
    {
        decimal media=0;
        while (true)
        {
            string m = Console.ReadLine();
            if (string.IsNullOrEmpty(m))
            {
                break;
            }

            int n = int.Parse(m);
            TrieNode r = new TrieNode();
            List<string> ps = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string p = Console.ReadLine();
                ps.Add(p);
                Gambi(r, p);
            }

            decimal teclas = 0;
            foreach (var p in ps)
            {
                teclas += Cont(r, p);
            }

            media = teclas / n;
            Console.WriteLine(media.ToString("F2"));
            media=0;
        }
    }

    static void Gambi(TrieNode r, string p)
    {
        TrieNode no = r;
        foreach (var c in p)
        {
            if (!no.Children.ContainsKey(c))
            {
                no.Children[c] = new TrieNode();
            }
            no = no.Children[c];
        }
        no.fim = true;
    }

    static int Cont(TrieNode r, string p)
    {
        TrieNode no = r;
        int tecladas = 1;  

        for (int i = 0; i < p.Length; i++)
        {
            char c = p[i];
            no = no.Children[c];

            if (i + 1 < p.Length)
            {
                char a = p[i + 1];
                if (no.Children.Count > 1 || no.fim || !no.Children.ContainsKey(a))
                {
                    tecladas++;
                }
            }
        }

        return tecladas;
    }
}

