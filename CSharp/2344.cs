using System;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("E");
        }
        else if (n >= 1 && n <= 35)
        {
            Console.WriteLine("D");
        }
        else if (n >= 36 && n <= 60)
        {
            Console.WriteLine("C");
        }
        else if (n >= 61 && n <= 85)
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("A");
        }
    }
}
