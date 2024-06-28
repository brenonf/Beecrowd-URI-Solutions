using System;
using System.Globalization;

class URI
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            string[] y = Console.ReadLine().Split();
            int pA = int.Parse(y[0]);
            int pB = int.Parse(y[1]);
            decimal tA = decimal.Parse(y[2]) / 100;
            decimal tB = decimal.Parse(y[3]) / 100;
            int anos = 0;

            while (pA <= pB)
            {
                pA += (int)(pA * tA);
                pB += (int)(pB * tB);
                anos++;

                if (anos > 100)
                {
                    break;
                }
            }

            if (anos <= 100)
            {
                Console.WriteLine($"{anos} anos.");
            }
            else
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
        }
    }
}
