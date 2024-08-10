using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = v[0];
        int b = v[1];
        int c = v[2];
        int d = v[3];

        if (Verificatrizaliamentalizamentaliazilacaosevoceestalendoissonessemomentoparabens_continueassim(a, b, c) || 
            Verificatrizaliamentalizamentaliazilacaosevoceestalendoissonessemomentoparabens_continueassim(a, b, d) || 
            Verificatrizaliamentalizamentaliazilacaosevoceestalendoissonessemomentoparabens_continueassim(a, c, d) || 
            Verificatrizaliamentalizamentaliazilacaosevoceestalendoissonessemomentoparabens_continueassim(b, c, d))
        {
            Console.WriteLine("S");
        }
        else
        {
            Console.WriteLine("N");
        }
    }

    static bool Verificatrizaliamentalizamentaliazilacaosevoceestalendoissonessemomentoparabens_continueassim(int x, int y, int z)
    {
        return Math.Abs(y - z) < x && x < (y + z) &&
               Math.Abs(x - z) < y && y < (x + z) &&
               Math.Abs(x - y) < z && z < (x + y);
    }
}
