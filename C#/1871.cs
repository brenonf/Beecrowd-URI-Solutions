using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
      string teste="";
      int soma=0;
      while(true)
     {
      int[] n =Console.ReadLine().Split().Select(int.Parse).ToArray();
      if(n[0]==0 && n[1]==0)
      {break;}
      soma=n[0]+n[1];
      teste = soma.ToString();

      teste = teste.Replace("0","");

      Console.WriteLine(teste);




     }

    }
}
