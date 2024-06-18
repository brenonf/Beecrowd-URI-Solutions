using System;
using System.Globalization;


class URI {

    static void Main(string[] args) {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());


            Console.WriteLine($"MEDIA = {(a*2f+b*3f+c*5)/10f:F1}");
        }

}