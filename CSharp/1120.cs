using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
      string n="";
      while(true)
      {
        n=Console.ReadLine();
        if(n==null || n=="0 0")
        {break;}

        string[] x=n.Split();
        x[1]=x[1].Replace(x[0],"").TrimStart('0');
        
        if (x[1] == "")
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(BigInteger.Parse(x[1]));
        }
      }
    }
}
