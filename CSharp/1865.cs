using System;

class URI
{
    static void Main()
    {
       int x = int.Parse(Console.ReadLine());
       string y;

       for(int i=0;i<x;i++)
       {
            if(Console.ReadLine().Split()[0]=="Thor")
            {
                Console.WriteLine("Y");
            }
            else{Console.WriteLine("N");}
       }
    }
}
