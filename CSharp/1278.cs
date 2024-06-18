using System; 


class URI 
{

    static void Main(string[] args) 
    {   int maior =0;

        while(true)
        {
        int n = int.Parse(Console.ReadLine());
        if(n==0)

        {break;}
        string [] sem;
        string[] print = new string[n];
        if(maior>0)
        {Console.WriteLine("");}
        maior=0;

        
        
        

        for(int i = 0; i < n;i++)
        {
        sem =Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
        print[i]=string.Join(" ",sem);
        }
        foreach(string p in print)
        {if(p.Length>maior)
        {
            maior=p.Length;
        }
        }

        for(int j =0;j<print.Length;j++)
        {
            while(print[j].Length<maior)
            {
                print[j] = " "+print[j];
            }
        }

        foreach(string p in print)
        {Console.WriteLine(p);}
        

        
    
    }
    }
}
