using System;
using System.Linq;

class URI
{
    static void Main()
    {
        string print = "YOU WIN";
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        

        int[] z = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for(int i =1;i<z.Length;i++)
        {
            if(Math.Abs(z[i-1]-z[i])>x[0])
            {print="GAME OVER";break;}
        }
        Console.WriteLine(print);
    }
}
