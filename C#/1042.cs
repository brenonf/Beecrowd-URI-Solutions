using System;
using System.Linq;



class Program {
    static void Main() 
    {
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] y = new int[3];

        Array.Copy(x, y, 3);
        Array.Sort(x);
        foreach (var item in x)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        foreach (var item in y)
        {
            Console.WriteLine(item);
        }
    }
}
       