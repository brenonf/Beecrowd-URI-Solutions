using System;
using System.Globalization;


class URI {

    static void Main(string[] args) {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            



            Console.WriteLine($"NUMBER = {a}");
            Console.WriteLine($"SALARY = U$ {b*c:F2}");
        }

}