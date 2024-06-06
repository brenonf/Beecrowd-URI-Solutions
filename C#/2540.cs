using System;



class URI 
{

    static void Main(string[] args) 
    { 
        while(true)
        {
            string x=Console.ReadLine();
            if(x==null)
            {break;}
        float uns=0;
      string[] n = Console.ReadLine().Split();
      float len=n.Length;

      foreach(string i in n)
      {
        if(i=="1")
        {
            uns+=1;
        }
      }
      if(Convert.ToDouble(uns)/len>=(2f/3))
      {
        Console.WriteLine("impeachment");
      }
      else{       
         Console.WriteLine("acusacao arquivada");

        }
        }
        
}}







