using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int[] x;
        int soma=0;
        while(true)
        {
            x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(Array.Exists(x,a=>a<=0))
            {break;}

            Array.Sort(x);

            for(int i =x[0];i<=x[1];i++)
            {
                Console.Write($"{i} ");
                soma+=i;
            }
            Console.WriteLine($"Sum={soma}");
            soma=0;
        }
    }
}