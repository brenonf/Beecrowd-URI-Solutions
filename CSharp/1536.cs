using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        int saldoGol1 =0;
        int saldoGol2 =0;
        int saldoCasa1=0;
        int saldoCasa2=0;
        int ponto1=0;
        int ponto2=0;
        int gol1;
        int gol2;
        string[] placar;


        int n = int.Parse(Console.ReadLine());
        for(int i =0;i<n;i++)
        {
            placar = Console.ReadLine().Split();
            gol1 =int.Parse(placar[0]);
            gol2=int.Parse(placar[2]);
            saldoGol1 +=gol1;
            saldoGol2 +=gol2;
            saldoCasa2+=gol2;
            if(gol1>gol2)
            {
                ponto1+=3;
            }
            else if(gol2>gol1)
            {
                ponto2+=3;
            }
            else
            {
                ponto1++;
                ponto2++;
            }

            placar = Console.ReadLine().Split();
            gol1 =int.Parse(placar[2]);
            gol2=int.Parse(placar[0]);
            saldoGol1 +=gol1;
            saldoGol2 +=gol2;
            saldoCasa1+=gol1;
             if(gol1>gol2)
            {
                ponto1+=3;
            }
            else if(gol2>gol1)
            {
                ponto2+=3;
            }
            else
            {
                ponto1++;
                ponto2++;
            }
            if(ponto1>ponto2)
            {Console.WriteLine($"Time 1");}

            else if(ponto2>ponto1)
            {Console.WriteLine("Time 2");}

            else
            {
                if(saldoGol1>saldoGol2)
                {
                    Console.WriteLine("Time 1");
                }
                else if(saldoGol2>saldoGol1)
                {
                    Console.WriteLine("Time 2");
                }
                else if(saldoCasa1>saldoCasa2)
                {
                    Console.WriteLine("Time 1");
                }
                else if(saldoCasa2>saldoCasa1)
                {
                    Console.WriteLine("Time 2");
                }
                else{Console.WriteLine("Penaltis");}
            }
            saldoGol1 =0;
            saldoGol2 =0;
            saldoCasa1=0;
            saldoCasa2=0;
            ponto1=0;
            ponto2=0;
            gol1=0;
            gol2=0;
        }
        

    }
}