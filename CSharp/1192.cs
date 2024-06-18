using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();

            if (x[0] == x[2])
            {
                int d = x[0] - '0'; 
                Console.WriteLine(d * d);
            }
            else if (char.IsUpper(x[1]))
            {
                int d1 = x[0] - '0'; 
                int d2 = x[2] - '0'; 
                Console.WriteLine(-d1 + d2);
            }
            else
            {
                int d1 = x[0] - '0'; 
                int d2 = x[2] - '0'; 
                Console.WriteLine(d1 + d2);
            }
        }
    }
}
