using System;
using System.Globalization;

class URI
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal soma =1;
        int x=2;

        for(int i =3;i<40;i+=2)
        {
            soma+=(decimal)i/x;
            x*=2;
        }   
        Console.WriteLine($"{soma:F2}");   
    }
}
