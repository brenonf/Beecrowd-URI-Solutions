using System;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        while (true) {
            decimal[] x = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            if(x[0]==0)
            {break;}

            decimal y =x[0]*x[1];

            Console.WriteLine($"{(int)Math.Truncate(Math.Sqrt((double)(y/(x[2]/100))))}");
        }
    }

}