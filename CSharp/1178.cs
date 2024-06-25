using System;

class URI
{
    static void Main(string[] args)
    {
        decimal x = decimal.Parse(Console.ReadLine());
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine($"N[{i}]={Math.Round(x,4,MidpointRounding.ToEven):F4}");
            x = decimal.Divide(x,2);
        }
    }
}
