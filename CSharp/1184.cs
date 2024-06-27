using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main()
    {
        char c= char.Parse(Console.ReadLine());
        decimal d;
        List<decimal> listao = new List<decimal>(); 
        

        for(int lin =0;lin<12;lin++)
        {
            for(int col =0;col<12;col++)
            {
                if(col+1<=lin)
                {
                    listao.Add(decimal.Parse(Console.ReadLine()));
                }
                else{Console.ReadLine();}
            }
        }
        if(c=='S')
        {Console.WriteLine($"{listao.Sum():F1}");}
        else{Console.WriteLine($"{listao.Average():F1}");}
    }
}
