using System;

class Program
{
    static void Main(string[] args)
    {
       int x= int.Parse(Console.ReadLine());
       int y= int.Parse(Console.ReadLine());

       if((x+y)%2==0)
       {
        Console.WriteLine(1);
       }
       else{Console.WriteLine(0);}
    }
}
