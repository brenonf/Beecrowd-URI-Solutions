using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i =2;i<10000;i++)
        {
            if(i%n==2)
            {Console.WriteLine(i);}
        }
    }
}
