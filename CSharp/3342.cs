using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n%2==0)
        {Console.WriteLine("{0} casas brancas e {1} casas pretas",Math.Pow(n,2)/2,Math.Pow(n,2)/2);}

        else
        {
            {Console.WriteLine("{0} casas brancas e {1} casas pretas",Convert.ToInt32(Math.Pow(n,2)/2)+1,Convert.ToInt32(Math.Pow(n,2)/2));}
        }
    }   

}
