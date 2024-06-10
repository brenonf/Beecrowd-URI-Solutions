using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] a;
        int b;
        int c;

        for (int i = 0; i < n; i++)
        {
            a = Console.ReadLine().Split('k');
            a[0] = a[0].Replace("h", "");
            a[0] = a[0].Replace("me", "");
            a[1] = a[1].Replace("k", "");
            a[1] = a[1].Replace("me", "");

            b = a[0].Length;
            c = a[1].Length;
            Console.WriteLine("k" + string.Concat(Enumerable.Repeat("a", b * c)));
        }
    }
}
