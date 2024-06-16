using System;

class Program
{
    static void Main()
    {   string A;
        string[] x;
        char a ='1';
        char b ='1';
        char c ='1';
        while(true)
        
        {
            A=Console.ReadLine();
            if(string.IsNullOrEmpty(A))
            {break;}
            x=A.Split();

            a=char.Parse(x[0]);
            b=char.Parse(x[1]);
            c=char.Parse(x[2]);

            if(a!=b && a!=c)
            {Console.WriteLine("A");}
            else if(b!=a && b!=c)
            {Console.WriteLine("B");}
            else if(c!=a && c!=b)
            {Console.WriteLine("C");}
            else
            {Console.WriteLine("*");}
        }
    }
}
