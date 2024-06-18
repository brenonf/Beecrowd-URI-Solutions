using System;
using System.Linq;
using System.Globalization;

class Program {
    static void Main() 
    {
        decimal[] lista  = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        if(lista[0]< lista[1]+ lista[2] && lista[1]<lista[0]+lista[2] && lista[2]< lista[0]+lista[1])
        {
            Console.WriteLine($"Perimetro = {lista[0]+lista[1]+lista[2]}");
        }
        else{
            Console.WriteLine($"Area = {(lista[0]+lista[1])*lista[2]/2:F1}");
        }
    }
}
       
   