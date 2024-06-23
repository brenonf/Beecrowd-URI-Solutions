using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        float r = float.Parse(Console.ReadLine());

        float i = 0;

        if (r <= 2000.00)
        {
            i = 0;
            Console.WriteLine("Isento");
        }
        else if (r <= 3000.00)
        {
            float r8 = r - 2000.00f;
            i = r8 * 0.08f;
        }
        else if (r <= 4500.00)
        {
            float i8 = 1000.00f * 0.08f;
            float r18 = r - 3000.00f;
            i = r18 * 0.18f + i8;
        }
        else
        {
            float i8 = 1000.00f * 0.08f;
            float i18 = 1500.00f * 0.18f;
            float r28 = r - 4500.00f;
            i = i18 + i8 + r28 * 0.28f;
        }

        if (r > 2000.00)
        {
            Console.WriteLine($"R$ {i:F2}");
        }
    }
}
