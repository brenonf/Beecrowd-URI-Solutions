using System;


class Program
{
    static void Main(string[] args)
    {
      string a;
      while((a=Console.ReadLine()) !=null)
      {
        double x = double.Parse(a)/100;

        Console.WriteLine((int)Math.Ceiling(x));
      }
    }
}


