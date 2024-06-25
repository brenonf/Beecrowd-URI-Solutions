using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main()
    {
        char c = char.Parse(Console.ReadLine());
        int aux =1;
        List<decimal> listao = new List<decimal>();

        for(int lin =0;lin<12;lin++)
        {
            for(int col=0;col<12;col++)
            {
                if(col>=aux)
                {
                    listao.Add(decimal.Parse(Console.ReadLine()));
                }
                else{Console.ReadLine();}
            }
            aux++;
        }        
        if(c=='M')
        {Console.WriteLine($"{listao.Average():F1}");}
        else{Console.WriteLine($"{listao.Sum():F1}");}
    }
}
