using System;
using System.Globalization;

class URI {
    static void Main(string[] args) {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        Console.ReadLine();
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        decimal total = Math.Round((b + c * 0.15m), 2, MidpointRounding.ToEven);
        Console.WriteLine($"TOTAL = R$ {total.ToString("F2")}");
    }
}
