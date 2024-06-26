using System; 
using System.Linq;
class URI 
{

    static void Main(string[] args) 
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] m = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        foreach(int j in m)
        {
            n[0]+=j;
            if(n[0]>100)
            {n[0]=100;}
            else if(n[0]<0)
            {n[0]=0;}
        }
        
        Console.WriteLine(n[0]);
        
    }

}
