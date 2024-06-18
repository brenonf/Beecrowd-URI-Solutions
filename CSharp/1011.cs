using System;
using System.Globalization;
using System.Linq;

class URI {
    static void Main(string[] args) {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        
        double a = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"VOLUME = {(4/3d)*3.14159d*Math.Pow(a,3):F3}");
    }
}
