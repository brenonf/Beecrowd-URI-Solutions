using System;
using System.Globalization;

class URI
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string[] x=Console.ReadLine().Split();
            float a=float.Parse(x[0]);
            float b=float.Parse(x[1]);
            float c=float.Parse(x[2]);

            float media = (a*2+b*3+c*5) / 10;

            Console.WriteLine(media.ToString("F1"));
        }
    }
}
