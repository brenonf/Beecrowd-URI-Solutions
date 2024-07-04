using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
     {
          char c =char.Parse(Console.ReadLine());
          int x=5;
          int y=6;
          List<decimal> listao=new List<decimal>();

          for(int i=0;i<12;i++)
          {
               for(int j=0;j<12;j++)
               {
                    if(i>=7 && j>=x && j<=y)
                    {
                         listao.Add(decimal.Parse(Console.ReadLine()));
                    }
                    else{Console.ReadLine();}
               }
               if(i>=7)
               {
                    x--;
                    y++;
               }
               
          }
          if(c=='S')
          {
               Console.WriteLine($"{listao.Sum():F1}");
          }
          else{Console.WriteLine($"{listao.Average():F1}");}


     }

}