using System;
using System.Linq;
//using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista;
            TimeSpan hora1;
            TimeSpan hora2;
            TimeSpan mid0;
            TimeSpan mid24;

            while (true)
            {
                lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (lista[0]==0 && lista[1]==0 && lista[2]==0 && lista[3]==0) { break; }
                hora1 = new TimeSpan(lista[0], lista[1], 0);
                hora2 = new TimeSpan(lista[2], lista[3], 0);
                mid0 = new TimeSpan(0, 0, 0);
                mid24 = new TimeSpan(24, 0, 0);


                if (hora1 <= hora2)
                { Console.WriteLine((hora2 - hora1).TotalMinutes); }
                else if (hora1 > hora2)
                {
                    Console.WriteLine(((mid24 - hora1) + (hora2 - mid0)).TotalMinutes);
                }
            }
           


        }
    }
}