using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
       int[] x =Console.ReadLine().Split().Select(int.Parse).ToArray();

      if(x[1]-x[0]>=3)
      {
        Console.WriteLine("Muito bem! Apresenta antes do Natal!");
      }
      else if(x[1]-x[0]<3 && x[1]-x[0]>=0)
      {
        Console.WriteLine("Parece o trabalho do meu filho!");
        if(x[0]+2<24)
        {Console.WriteLine("TCC Apresentado!");}
        else
        {
          {Console.WriteLine("Fail! Entao eh nataaaaal!");}
        }
}     else{
      Console.WriteLine("Eu odeio a professora!");
}
      }


    }
