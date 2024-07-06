using System; 

class URI {

    static void Main(string[] args) 
    {
        int soma=0;

        int x = int.Parse(Console.ReadLine());
        int y;

        for(int i =0;i<x;i++)
        {
            y=int.Parse(Console.ReadLine());
            for(int j =1;j<=y;j++)
            {
                if(j%2!=0)
                {
                    soma++;
                }
                else{soma--;}
            }
            Console.WriteLine(soma);
            soma=0;
        }
    }
}