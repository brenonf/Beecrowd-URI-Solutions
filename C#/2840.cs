using System;
using System.Linq;


class Program {
    static void Main() 
    {
       int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        decimal area = (4m / 3m) * (3.1415m * (decimal)Math.Pow(x[0], 3));
        Console.WriteLine(Convert.ToInt32(Math.Floor(x[1]/area)));
    }
}
       
   