using System; 
using System.Linq;

class URI 
{

    static void Main(string[] args) 
    {
        int[] vetor = new int[10];
        for (int i =0;i<10;i++)
        {
            vetor[i]=int.Parse(Console.ReadLine());
        }
        vetor=vetor.Select(x=>x<=0 ?1:x).ToArray();
        for(int i=0;i<10;i++)
        {Console.WriteLine($"X[{i}] = {vetor[i]}");}
    }

}