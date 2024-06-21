using System; 

class URI {

    static void Main(string[] args) 
    {
        int[] fibo =new int[46];

        fibo[0]=0;
        fibo[1]=1;
        for(int i =2;i<46;i++)
        {
            fibo[i]=fibo[i-2]+fibo[i-1];
        }

        int n = int.Parse(Console.ReadLine());
        for(int i = 0;i<n-1;i++)
        {Console.Write($"{fibo[i]} ");}
        Console.WriteLine(fibo[n-1]);

    }

}

