using System; 
using System.Linq;
using System.Collections.Generic;


class URI 
{

    static void Main(string[] args) 
    {   
        int[] n;
        int[] lista;
        List<int> listao = new List<int>();
        int cont=0;


        while(true)
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0)
            {
                break;
            }
            lista =Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i =0;i<n[1];i++)
            {
                for(int j =0;j<n[1];j++)
                {
                    listao.Add(lista[i]-lista[j]);
                }
            }
            listao = listao.Select(x=>Math.Abs(x)).ToList();
            for(int i=0; i<=n[0];i++)
            {
                if(listao.Contains(i))
                {cont++;}
            }
            if(cont==n[0]+1)
            {Console.WriteLine("Y");}
            else{Console.WriteLine("N");}
            cont=0;
            listao.Clear();
            
        }
    }
}