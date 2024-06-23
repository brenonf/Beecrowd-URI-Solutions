using System;
using System.Globalization;

class URI
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture =new CultureInfo("en-US");
        decimal[] listao = new decimal[100];
        for (int i =0;i<100;i++)
        {
            listao[i] = decimal.Parse(Console.ReadLine());
        }
        for (int i =0;i<100;i++)
        {
            if(listao[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {listao[i]:F1}");
            }
        }
    }
}
