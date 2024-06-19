using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            decimal media=0;
            int cont=0;
            decimal n;

            for(int i =0;i<6;i++)
            {
                n = decimal.Parse(Console.ReadLine());
                if(n>0)
                {
                    cont++;
                    media+=n;
                }
            }
            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine($"{(decimal)media/cont:F1}");
        } 
}
}
