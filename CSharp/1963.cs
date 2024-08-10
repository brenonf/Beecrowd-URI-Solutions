using System;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        decimal[] x = Console.ReadLine().Split().Select(y=>decimal.Parse(y)).ToArray();
        decimal a = x[0];
        decimal b = x[1];

        Console.WriteLine($"{((b-a)/a)*100:F2}%");
    }

}