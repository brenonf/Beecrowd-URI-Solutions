using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m;
        string movimento;
        List<string> movimentos = new List<string>();
        int ponto=0;

        for(int i =0;i<n;i++)
        {
            m = int.Parse(Console.ReadLine());
            for(int j =0;j<m;j++)
            {
                movimento =Console.ReadLine();
                if(movimento =="LEFT")
                {
                    ponto--;
                    movimentos.Add("LEFT");
                }
                else if(movimento =="RIGHT")
                {
                    ponto++;
                    movimentos.Add("RIGHT");
                }
                else
                {
                    movimento =movimentos[int.Parse(movimento.Split()[2])-1];
                    if(movimento =="LEFT")
                        {
                            ponto--;
                            movimentos.Add("LEFT");
                        }
                    else if(movimento =="RIGHT")
                        {
                            ponto++;
                            movimentos.Add("RIGHT");
                        }
                }
            }
            Console.WriteLine(ponto);
            movimentos.Clear();
            ponto=0;

        }
    }
}