using System;
using System.Linq;
using System.Collections.Generic;
class URI 
{
    static void Main(string[] args) 
    {
        int[] gp;
        List<int> resultadoCorrida;
        List<int> pontuacaoPilotos = new List<int>();
        List<int> sistemaDePontuacao = new List<int>();
        int sistemas;
        int[] sistema;
        List<int> print = new List<int>();

        while(true)
        {
            gp =Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(gp[0]==0 &&gp[1]==0)
            {break;}

            List<List<int>> colocacoes = new List<List<int>>();
            for (int i = 0; i < gp[1]; i++)
            {
                colocacoes.Add(new List<int>());
            }

            for(int i=0; i < gp[0];i++)
            {
                resultadoCorrida=Console.ReadLine().Split().Select(int.Parse).ToList();
                for(int j=0;j<gp[1];j++)
                {
                    colocacoes[j].Add(resultadoCorrida[j]);
                }                
            }
            sistemas = int.Parse(Console.ReadLine());
            for(int i=0;i<sistemas;i++)
            {
                sistema =Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j=0; j<gp[1];j++)
                {
                    pontuacaoPilotos.Add(0);
                    for(int s=1;s<=sistema[0];s++)
                    {
                        pontuacaoPilotos[j]+=sistema[s]*colocacoes[j].Count(x=>x==s);
                    }
                }
                for(int indice=0; indice<gp[1];indice++)
                {
                    if(pontuacaoPilotos[indice]==pontuacaoPilotos.Max())
                    {
                        print.Add(indice+1);
                    }
                }
                Console.WriteLine(string.Join(" ",print));
                print.Clear();
                pontuacaoPilotos.Clear();
            }

        }
    }
}
        
