using System;

class Program
{
    static void Main(string[] args)
    {
        string[] v = Console.ReadLine().Split();
        double a = double.Parse(v[0]);
        double b = double.Parse(v[1]);
        double c = double.Parse(v[2]);

        if (a == 0.0f || (b * b - 4 * a * c) < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double delta = (double)Math.Sqrt(b * b - 4 * a * c);
            double x1 = (-b + delta) / (2 * a);
            double x2 = (-b - delta) / (2 * a);
            Console.WriteLine($"R1 = {x1:F5}");
            Console.WriteLine($"R2 = {x2:F5}");
        }
    }
}
