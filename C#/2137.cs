using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
      while(true)
      {
        string n=Console.ReadLine();
        if(n==null)
        {break;}
        string[] lista =new string[int.Parse(n)];
        for(int i =0;i<int.Parse(n);i++)
        {
          lista[i]= Console.ReadLine();
        }
        Array.Sort(lista);
        foreach(string i in lista)
        {Console.WriteLine(i);}
      }
    }
}
