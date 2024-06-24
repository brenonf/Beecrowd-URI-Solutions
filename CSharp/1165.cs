using System;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x;
        for (int i = 0;i<n;i++)
        {
            x = int.Parse(Console.ReadLine());
            if(Primo(x))
            {Console.WriteLine($"{x} eh primo");}
            else{Console.WriteLine($"{x} nao eh primo");}
        }
    }

    static bool Primo(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }
}