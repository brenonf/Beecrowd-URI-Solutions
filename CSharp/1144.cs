using System; 

class URI {

    static void Main(string[] args) 
    {
        ulong x = ulong.Parse(Console.ReadLine());
        ulong y=0;
        ulong z=0;

        for(ulong i = 1; i <= x;i++)
        {
            y=i*i;
            z=i*i*i;
            Console.WriteLine($"{i} {y} {z}");
            Console.WriteLine($"{i} {y+1} {z+1}");
        }
    }

}