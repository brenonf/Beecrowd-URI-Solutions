using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        
               
        Console.WriteLine($"{(double)x/y:F3} km/l");

    }
}
