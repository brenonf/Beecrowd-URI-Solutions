using System;
using System.Globalization;


class URI {

    static void Main(string[] args) {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {(a*3.5f+b*7.5f)/11f:F5}");
        }

}