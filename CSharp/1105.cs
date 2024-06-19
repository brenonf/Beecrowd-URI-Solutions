using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] n;
        int[] reservas;
        int[] deb;
        bool deubom = true;

        while(true)
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0)
            {break;}

            reservas = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i =0;i<n[1];i++)
            {
                deb = Console.ReadLine().Split().Select(int.Parse).ToArray();
                reservas[deb[0]-1] -=deb[2];
                reservas[deb[1]-1]+=deb[2];
            }
            foreach(int reserva in reservas)
            {
                if(reserva<0)
                {
                    deubom=false;
                    Console.WriteLine("N");
                    break;
                }
            }
            if(deubom)
            {Console.WriteLine("S");}
            deubom=true;
            // foreach(int reserva in reservas)
            // {Console.WriteLine(reserva);}




        }
    }
}