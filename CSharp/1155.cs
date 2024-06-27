using System;
using System.Globalization;

class URI
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal s =1;
        for (int i =2;i<101;i++)
        {
            s+=(decimal)1/i;
        }
        Console.WriteLine($"{s:F2}");
    }        
}
