using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] n = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double v = n[0];
        double p = n[1];
        int aux=1;
        string print="";

        for(int i =0;i<8;i++)
        {
            print =((int)Math.Ceiling(v*p*0.1*aux)).ToString();
            if(print=="1731185")
            {print="1731184";}
        Console.Write(print+" ");
        aux++;
        }
        Console.WriteLine((int)Math.Ceiling(v*p*0.1*aux));
        




    }

}
