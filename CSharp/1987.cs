using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {   
        string x;
        char[] n;
        int soma=0;
        while(true)
        {
            x= Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}

            n =x.Split()[1].ToCharArray();
            soma=n.Select(ch=>int.Parse(ch.ToString())).Sum();
            if(soma%3==0)
            {Console.WriteLine($"{soma} sim");}
            else{Console.WriteLine($"{soma} nao");}
        }
    }
}