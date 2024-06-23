using System;
using System.Linq;
class URI
{
    static void Main(string[] args)
    {
        int[] x;
        while(true)
        {
            x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(x[0]>0 && x[1]>0)
            {
                Console.WriteLine("primeiro");
            }
            else if(x[0]>0 && x[1]<0)
            {
                Console.WriteLine("quarto");
            }
            else if(x[0]<0 && x[1]>0)
            {Console.WriteLine("segundo");}
            else if(x[0]<0 && x[1]<0)
            {Console.WriteLine("terceiro");}
            else if(x[0]==0 || x[1]==0)
            {break;}
        }
    }
}
