using System;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int j = 1;
            int s = 0;

            while (j < num)
            {
                if (num % j == 0)
                {
                    s += j;
                }

                j++;
            }

            if (s == num)
            {
                Console.WriteLine($"{num} eh perfeito");
            }
            else
            {
                Console.WriteLine($"{num} nao eh perfeito");
            }
        }
    }
}
