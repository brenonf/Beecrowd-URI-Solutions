using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
     {
          char c =char.Parse(Console.ReadLine());
          int x=-1;
          
          List<decimal> listao=new List<decimal>();

          for(int i=0;i<12;i++)
          {
               for(int j=0;j<12;j++)
               {
                    if(j<=x)
                    {
                         listao.Add(decimal.Parse(Console.ReadLine()));
                    }
                    else{Console.ReadLine();}
               }
               if(i<=4)
               {
                    x++;
               }
               else if(i>=6)
               {x--;}
               
          }
          if(c=='S')
          {
               Console.WriteLine($"{listao.Sum():F1}");
          }
          else{Console.WriteLine($"{listao.Average():F1}");}


     }

}