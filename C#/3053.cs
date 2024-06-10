using System;

class Program
{
    static void Main(string[] args)
    {
      bool a=false;
      bool b=false;
      bool c=false;
      bool aux=false;

      int n = int.Parse(Console.ReadLine());
      string copo = Console.ReadLine();
      if(copo=="A")
      {a=true;}
      else if(copo=="B")
      {b=true;}
      else{c=true;}

      for(int i =0;i<n;i++)
      {
        copo=Console.ReadLine();
        if(copo=="1")
        {
            aux=a;
            a=b;
            b=aux;
        }
        else if(copo=="2")
        {
            aux=b;
            b=c;
            c=aux;}
        else{
            aux=a;
            a=c;
            c=aux;
        }
      }

      if(a)
      {Console.WriteLine("A");}
      if(b)
      {Console.WriteLine("B");}
      if(c)
      {Console.WriteLine("C");}
    }
}