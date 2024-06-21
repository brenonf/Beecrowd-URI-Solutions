using System; 

class URI {

    static void Main(string[] args) 
    { 
        Console.WriteLine(fatorial(int.Parse(Console.ReadLine())));
    }

    public static int fatorial(int x)
    {
        if(x==1 || x==0)
        {
            return 1;
        }
        else
        {
            return x*(fatorial(x-1));

        }
    } 
}