using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int x = int.Parse(Console.ReadLine());
        int[] listao = new int[x];
        int[] y = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach(var i in y)
        {
            if(i%2==0)
            {listao[0]++;}
            if(i%3==0)
            {listao[1]++;}
            if(i%4==0)
            {listao[2]++;}
            if(i%5==0)
            {listao[3]++;}
        }
        Console.WriteLine($"{listao[0]} Multiplo(s) de 2");
        Console.WriteLine($"{listao[1]} Multiplo(s) de 3");
        Console.WriteLine($"{listao[2]} Multiplo(s) de 4");
        Console.WriteLine($"{listao[3]} Multiplo(s) de 5");



    }
}