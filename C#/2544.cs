using System;

class Program
{
    static void Main(string[] args)
    {
        int n=0;
        int cont=0;
        string x="";
        
        while(true)
        {
            x=Console.ReadLine();
            if(x==null)
            {break;}
            n = int.Parse(x);

            while(Math.Pow(2,cont)!= n)
            {cont++;}

            Console.WriteLine(cont);
            cont=0;

        }
        
                
    }
}

