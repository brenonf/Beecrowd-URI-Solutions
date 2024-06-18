using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int c = int.Parse(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            long[] n = Console.ReadLine().Split().Select(long.Parse).ToArray();
            BigInteger result = Power(n[0], n[1]);
            string print = result.ToString();
            //Console.WriteLine(print);
            Console.WriteLine(print.Length);
        }
    }

    static BigInteger Power(long x, long y)
    {
        BigInteger result = 1;
        BigInteger baseNum = x;
        
        while (y > 0)
        {
            if ((y & 1) == 1)
            {
                result *= baseNum;
            }
            baseNum *= baseNum;
            y >>= 1;
        }

        return result;
    }
}
