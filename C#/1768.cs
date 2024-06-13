using System;

class Program
{
    static void Main(string[] args)
    {
        string a;
        int n;

        while ((a = Console.ReadLine()) != null)
        {
            n = int.Parse(a);

            for (int i = n / 2, j = 1; i >= 0; --i, j += 2)
            {
                string x = new string(' ', i) + new string('*', j);
                Console.WriteLine(x);
            }

            string pe = new string(' ', n / 2) + "*";
            Console.WriteLine(pe);

            string pe2 = new string(' ', n / 2 - 1) + "***";
            Console.WriteLine(pe2 + "\n");
        }
    }
}
