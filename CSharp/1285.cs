using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] n;
        int aux;
        int cont=0;
        string x;

        while(true)
        {
            x=Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}
            n = x.Split().Select(int.Parse).ToArray();
            aux = n[0];
            while(aux<=n[1])
            {
                if(aux.ToString().ToCharArray().Length==aux.ToString().ToCharArray().Distinct().Count())
                {
                    cont++;
                }
                aux++;
            }
            Console.WriteLine(cont);
            cont=0;
        }

    }
}