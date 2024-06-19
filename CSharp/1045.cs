using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        float[] x = Console.ReadLine().Split().Select(float.Parse).ToArray();
        float a = x[0], b = x[1], c = x[2];

        if (a < b)
        {
            float temp = a;
            a = b;
            b = temp;
        }
        if (a < c)
        {
            float temp = a;
            a = c;
            c = temp;
        }
        if (b < c)
        {
            float temp = b;
            b = c;
            c = temp;
        }

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
