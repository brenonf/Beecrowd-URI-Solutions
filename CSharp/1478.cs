using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            short n = short.Parse(Console.ReadLine());
            short[,] matrix = new short[n, n];

            if (n == 0)
                return;

            for (short l = 0; l < n; l++)
            {
                for (short c = 0; c < n; c++)
                {
                    if (l == c)
                        matrix[l, c] = 1;
                    if (l < c)
                        matrix[l, c] = (short)(c - l + 1);
                    if (l > c)
                        matrix[l, c] = (short)(l - c + 1);
                }
            }

            // Impressão da matrix
            for (short l = 0; l < n; l++)
            {
                for (short c = 0; c < n; c++)
                {
                    if (c == 0)
                        Console.Write("{0,3}", matrix[l, c]);
                    else
                        Console.Write(" {0,3}", matrix[l, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
