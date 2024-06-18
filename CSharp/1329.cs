using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int n;
        int[] lista;
        int m=0;
        int j=0;
       

        while(true)
        {
            n = int.Parse(Console.ReadLine());
            if(n==0)
            {break;}

            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach(int i in lista)
            {
                if(i==0)
                {m++;}
                else{j++;}
            }
            Console.WriteLine($"Mary won {m} times and John won {j} times");
            j=0;
            m=0;

          
        }
              
        
        
    }

        

}

