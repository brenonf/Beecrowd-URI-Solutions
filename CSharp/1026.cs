using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {       
            string a = Console.ReadLine();
            if (string.IsNullOrEmpty(a))
            {
                break;
            }

            string[] inputs = a.Split();
            long x = long.Parse(inputs[0]);
            long y = long.Parse(inputs[1]);
            Console.WriteLine(x ^ y);
        }
    }
}
