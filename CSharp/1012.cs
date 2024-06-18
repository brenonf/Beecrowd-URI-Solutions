using System;
using System.Globalization;
using System.Linq;

class URI {
    static void Main(string[] args) {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        
        double[] a = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double x = a[0];
        double y = a[1];
        double z = a[2];
        
        Console.WriteLine($"TRIANGULO: {x*z/2d:F3}");
        Console.WriteLine($"CIRCULO: {3.14159d*Math.Pow(z,2):F3}");
        Console.WriteLine($"TRAPEZIO: {((x+y)*z)/2d:F3}");
        Console.WriteLine($"QUADRADO: {y*y:F3}");
        Console.WriteLine($"RETANGULO: {x*y:F3}");

    }
}
