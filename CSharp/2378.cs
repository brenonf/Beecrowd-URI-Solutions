using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int acumulado=0;
        int[] movimento;
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string print ="N";

        for(int i =0;i<n[0];i++)
        {
            movimento=Console.ReadLine().Split().Select(int.Parse).ToArray();
            acumulado -= movimento[0];
            acumulado += movimento[1];
            if(acumulado>n[1])
            {print="S";}

        }
        Console.WriteLine(print);
    }

}