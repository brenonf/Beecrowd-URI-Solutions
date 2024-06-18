using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());
      int k = int.Parse(Console.ReadLine());
      int cont= k;
      
      int[] play = new int[n];
      
      for(int i=0; i<n;i++)
      {
          play[i] = int.Parse(Console.ReadLine());
      }
      
      Array.Sort(play);
      Array.Reverse(play);
     
      
      for(int i=k; i<n;i++ )
      {
          if( play[i]==play[i-1])
          {cont+=1;}
          else
          {break;}
          
      }
      Console.WriteLine(cont);
    
    
              
      
    }
}
