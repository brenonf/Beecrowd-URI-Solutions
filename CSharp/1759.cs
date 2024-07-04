using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            sb.Append("Ho");

            if (i == n - 1)
            {
                sb.Append("!");
            }
            else
            {
                sb.Append(" ");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
