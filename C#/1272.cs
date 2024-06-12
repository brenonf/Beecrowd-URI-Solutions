using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] a;
        string b = "";

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("");
                continue;
            }

            a = line.Split();

            foreach (string x in a)
            {
                if (!string.IsNullOrEmpty(x))
                {
                    b += x[0];
                }
            }

            Console.WriteLine(b);
            b = "";
        }
    }
}
