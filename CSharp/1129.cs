using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {   
        int n;
        int[] listao;
        int cont=0;
        int print=0;
        char[] letra = new char[5]{'A','B','C','D','E'};

        while(true)
        {
            n = int.Parse(Console.ReadLine());
            if(n==0)
            {break;}
            for(int i=0; i<n;i++)
            {
                listao = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int x=0;x<5;x++)
                {
                    if(listao[x]<=127)
                    {cont++;print=x;}
                    if(cont>1)
                    {Console.WriteLine("*");
                        break;}
                }
                if(cont==1)
                {
                    Console.WriteLine(letra[print]);
                }
                else if(cont==0)
                {Console.WriteLine("*");}
                cont=0;
                
            }
        }
        

    }

}