using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int n = int.Parse(Console.ReadLine());
        int c=0; 
        int r=0;
        int s=0;

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int qtd = int.Parse(input[0]);
            char x = char.Parse(input[1]);

            switch (x)
            {
                case 'C':
                    c += qtd;
                    break;
                case 'R':
                    r += qtd;
                    break;
                case 'S':
                    s += qtd;
                    break;
            }
        }

        int total = c + r + s;
        double pc=(c / (double)total)*100;
        double pr=(r / (double)total)*100;
        double ps=(s / (double)total)*100;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {c}");
        Console.WriteLine($"Total de ratos: {r}");
        Console.WriteLine($"Total de sapos: {s}");
        Console.WriteLine($"Percentual de coelhos: {pc.ToString("F2")} %");
        Console.WriteLine($"Percentual de ratos: {pr.ToString("F2")} %");
        Console.WriteLine($"Percentual de sapos: {ps.ToString("F2")} %");
    }
}
