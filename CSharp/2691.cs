using System;
using System.Linq;

class URI
{
    static void Main()
    {
        int n =int.Parse(Console.ReadLine());

        for(int i=0;i<n;i++)
        {
            int[] x = Console.ReadLine().Split('x').Select(int.Parse).ToArray();

            if(x[0]==x[1])
            {
                for(int j=5;j<11;j++)
                {
                    Console.WriteLine($"{x[0]} x {j} = {x[0]*j}");
                }
            }
            else
            {
                for(int j=5;j<11;j++)
                {
                    Console.WriteLine($"{x[0]} x {j} = {x[0]*j} && {x[1]} x {j} = {x[1]*j}");
                }
            }
        }
        
    }
}
