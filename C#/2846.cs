using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] lista = new int[n];
        int vai =4;
        int cont=0;
       
        while(cont<n)
        {
            if(Program.fibo(vai)==true)
            { 
                lista[cont]=vai;
                cont++;
               
            }
             vai++;
        }
        Console.WriteLine(vai-1);

        // foreach(int i in lista)
        // {Console.WriteLine(i);}
    }







    static bool fibo(int x)
{   
    if (x == 1 || x == 2)
    {
        return false;
    }

    int um = 1;
    int dois = 2;

    while (dois < x)
    {
        int aux = um + dois;
        um = dois;
        dois = aux;
    }

   
    return dois != x;
    }



        
    }
