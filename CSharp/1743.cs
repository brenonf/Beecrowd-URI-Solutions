using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {   
        bool deu =true;
        int[] lista1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] lista2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for(int i = 0;i<5;i++)
        {
            if(lista1[i]==lista2[i])
            {deu=false;
            break;}
        }
        if(deu)
        {Console.WriteLine("Y");}
        else{Console.WriteLine("N");}

        
        
        
     }

        

    }

