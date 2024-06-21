using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int cont=0;
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] lista = new int[n[1]];

        for(int i=0;i<n[0];i++)
        {
            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(!lista.Contains(0))
            {
                cont++;
            }
        }
        Console.WriteLine(cont);
    }
}