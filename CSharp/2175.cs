using System;
using System.Linq;
using System.Globalization;

class URI 
{
    static void Main(string[] args) 
    {   
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal[] n = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

        if(n[0]< n[1] &&n[0]<n[2])
        {Console.WriteLine("Otavio");}
        else if(n[1]< n[0] &&n[1]<n[2])
        {Console.WriteLine("Bruno");}
        else if(n[2]< n[0] &&n[2]<n[1])
        {Console.WriteLine("Ian");}
        else{Console.WriteLine("Empate");}
    }
}