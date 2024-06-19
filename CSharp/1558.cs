using System;

class Program
{
    static void Main(string[] args)
    {   
        string x;
        int n;

        while (true)
        {
            x = Console.ReadLine();
            if (string.IsNullOrEmpty(x))
            {
                break;
            }

            n = int.Parse(x);
            bool yes = false;

            for (int a = 0; a * a <= n; a++)
            {
                int quad = n - a * a;
                int b = (int)Math.Sqrt(quad);
                if (b * b == quad)
                {
                    yes = true;
                    break;
                }
            }

            if (yes)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
