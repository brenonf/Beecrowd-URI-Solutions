using System;


class Program
{
    static void Main(string[] args)
    {
     int n = int.Parse(Console.ReadLine());
     string[] x = Console.ReadLine().Split();
     int a = int.Parse(x[0]);
     int b = int.Parse(x[2]);
     

     if(x[1]=="*")
     {
      if(a*b<=n)
      {Console.WriteLine("OK");}
      else
      {
        Console.WriteLine("OVERFLOW");
      }
     }

     if(x[1]=="+")
     {
      if(a+b<=n)
      {Console.WriteLine("OK");}
      else
      {
        Console.WriteLine("OVERFLOW");
      }
     }


    }

    
}
