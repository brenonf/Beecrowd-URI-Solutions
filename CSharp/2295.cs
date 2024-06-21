using System;
using System.Linq;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {   
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal[] n= Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        if((decimal)n[0]/n[2]<(decimal)n[1]/n[3])
        {
            Console.WriteLine("A");
        }
        else{Console.WriteLine("G");}
    }
}