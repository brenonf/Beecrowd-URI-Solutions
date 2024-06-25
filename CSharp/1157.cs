using System;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i =1;i<=n;i++)
        {
            if(n%i==0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
