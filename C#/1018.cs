using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int[] b = { 100, 50, 20, 10, 5, 2, 1 };
        int[] c = new int[7];

        Console.WriteLine(a);

        for (int i = 0; i < b.Length; i++)
        {
            int x = a / b[i];
            a -= x * b[i];
            c[i] = x;
        }

        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine($"{c[i]} nota(s) de R$ {b[i]},00");
        }
    }
}
