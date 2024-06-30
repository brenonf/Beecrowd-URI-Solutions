using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        char c = char.Parse(Console.ReadLine());
        int aux =1;
        List<decimal> listao = new List<decimal>();

        for(int lin =0; lin < 12; lin++)
        {
            for(int col =0;col<12;col++)
            {
                if((lin<=4) && (col>=aux) && (col<=11-aux))
                {
                    listao.Add(decimal.Parse(Console.ReadLine()));
                }
                else{Console.ReadLine();}
            }
            aux++;
        }
        if(c=='S')
        {
            Console.WriteLine($"{listao.Sum():F1}");
        }
        else{Console.WriteLine($"{listao.Average():F1}");}
    }
}
