using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        int n;
        int soma=9999;

        string print="";
        string[] planeta;


        while (true)
        {
            n =int.Parse(Console.ReadLine());
            if(n == 0)
            {break;}

            for(int i=0;i<n;i++)
            {
                planeta = Console.ReadLine().Split();
                if(int.Parse(planeta[1])-int.Parse(planeta[2])<soma)
                {
                    soma=int.Parse(planeta[1])-int.Parse(planeta[2]);
                    print=planeta[0];
                }
            }
            Console.WriteLine(print);
            soma=9999;
        }
    }
}