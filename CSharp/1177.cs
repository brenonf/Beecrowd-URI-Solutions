using System;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cont=0;
        while(cont<1000)
        {
            for(int i =0; i<n; i++)
            {
                Console.WriteLine($"N[{cont}] = {i}");
                cont++;
                if(cont==1000)
                {break;}
            }
        }
    }
}
