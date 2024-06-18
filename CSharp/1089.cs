using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int n;
        int[] lista;
        int picos=0;

        while(true)
        {
            n = int.Parse(Console.ReadLine());
            if(n==0)
            {break;}

            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < n;i++)
            {
                if(i==0)
                {
                    if((lista[i]>lista[i+1] && lista[i]>lista[n-1]) || (lista[i]<lista[i+1] && lista[i]<lista[n-1]) )
                    {picos++;}
                }
                else if(i==(n-1))
                {
                    if((lista[i]>lista[0] && lista[i]>lista[i-1]) || (lista[i]<lista[0] && lista[i]<lista[i-1] ))
                    {picos++;}
                }
                else
                {
                    if((lista[i]>lista[i+1] && lista[i]>lista[i-1]) ||(lista[i]<lista[i+1] && lista[i]<lista[i-1]))
                    {
                        picos++;
                    }
                }
            }
            Console.WriteLine(picos);
            picos=0;
        }
              
        
        
    }

        

}

