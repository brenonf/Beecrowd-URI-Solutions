using System;
using System.Linq;
using System.Globalization;


class URI {

    static void Main(string[] args) 
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int[] x;
        int n = int.Parse(Console.ReadLine());
        for(int i =0; i<n; i++)
        {
            x=Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(x[1]==0)
            {Console.WriteLine("divisao impossivel");}
            else{Console.WriteLine($"{(decimal)x[0]/x[1]:F1}");}
        }
    }

}

