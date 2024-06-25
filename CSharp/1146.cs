using System;
using System.Text;

class URI
{
    static void Main()
    {
        int n;
        StringBuilder print = new StringBuilder();

        while (true)
        {
            n = int.Parse(Console.ReadLine());
            if (n == 0)
            {break;}

            for (int i = 1; i < n; i++)
            {
                print.Append($"{i} ");
            }
            print.Append(n);
            Console.WriteLine(print);
            print.Clear();
        }
    }
}
