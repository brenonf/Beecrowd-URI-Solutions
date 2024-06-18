using System;
using System.Globalization;
using System.Linq;

class URI {
    static void Main(string[] args) {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = a[0];
        int y = a[1];
        int z = a[2];
        
        int maior = ((x+y+Math.Abs(x-y))/2);
        maior = ((z+maior+Math.Abs(z-maior))/2);
        
        Console.WriteLine($"{maior} eh o maior");

    }
}
