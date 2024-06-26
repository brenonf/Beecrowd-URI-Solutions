using System;
using System.Globalization;

class URI
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal a = -0.2m;

        while (true)
        {
            a += 0.2m;
            for (int i = 1; i <= 3; i++)
            {
                string formatA = Gambiarra(a) ? $"{a:F0}" : $"{a:F1}";
                string formatJ = Gambiarra(a + i) ? $"{a + i:F0}" : $"{a + i:F1}";
                Console.WriteLine($"I={formatA} J={formatJ}");
            }
            if (a == 2)
            {
                break;
            }
        }
    }

    static bool Gambiarra(decimal z)
    {
        return z == Math.Floor(z);
    }
}
