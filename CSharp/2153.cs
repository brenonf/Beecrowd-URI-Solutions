using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string x;
        while (true)
        {
            x = Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}
            string aaaa = Gambi(x);
            Console.WriteLine(aaaa);
        }
    }

    static string Gambi(string pala)
    {
        int n = pala.Length;

        for (int i=1;i<=n/2;i++)
        {
            string suf = pala.Substring(n - i, i);
            string pref = pala.Substring(n - 2 * i, i);

            if (suf == pref)
            {
                return pala.Substring(0, n - i);
            }
        }

        return pala;
    }
}
