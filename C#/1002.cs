using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

       double x = double.Parse(Console.ReadLine());
       CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
       Console.WriteLine($"A={3.14159*Math.Pow(x,2):F4}");

    }

}