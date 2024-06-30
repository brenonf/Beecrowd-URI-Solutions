using System;

class URI
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = x - 1;

        int i = 2;
        int soma = x;
        int s = 1;
        
        while (z <= x)
        {
            z = int.Parse(Console.ReadLine());
        }

        while (soma <= z)
        {
            soma+= + x + s;

            if (soma <= z)
            {
                i = i + 1;
                s = s + 1;
            }
        }
        
        Console.WriteLine(i);
    }
}
