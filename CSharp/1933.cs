using System;

class URI
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split();
        int x = int.Parse(a[0]);
        int y = int.Parse(a[1]);

        int c;
        if (x == y)
        {
            c = x;
        }
        else if (x > y)
        {
            c = x;
        }
        else
        {
            c = y;
        }

        Console.WriteLine(c);
    }
}
