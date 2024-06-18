using System;


class Program
{
    static void Main(string[] args)
    {
     int cont1=0;
     int cont2=0;
     int n = int.Parse(Console.ReadLine());

     for(int i=0;i<n;i++)
     {
        string a =Console.ReadLine();
        if(a.Length==5)
        {Console.WriteLine(3);}
        else
        {
            if(a[0]=='t')
            {cont2++;}
            else if(a[0]=='o')
            {cont1++;}

            if(a[1]=='w')
            {cont2++;}
            else if(a[1]=='n')
            {cont1++;}

            if(a[2]=='o')
            {cont2++;}
            else if(a[2]=='e')
            {cont1++;}

        if(cont1>=2)
        {Console.WriteLine(1);}
        if(cont2>=2)
        {Console.WriteLine(2);}
        cont1=0;
        cont2=0;
        }
        
     }     

    }

    
}
