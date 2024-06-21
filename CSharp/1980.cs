using System;
using System.Numerics;

class URI
{
    static void Main(string[] args)
    {
        string n;
        while(true)
        {
            n = Console.ReadLine();
            if(n == "0")
            {break;}
            Console.WriteLine(Fat(n.Length));
        }
    }

    static BigInteger Fat(int n)
    {
        if(n==0 || n==1)
        {
            return 1;
        }
        else{return n*Fat(n-1);}
    }
}