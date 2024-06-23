using System; 

class URI {

    static void Main(string[] args) 
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int soma =0;
        if (a > b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        if(Math.Abs(b-a)-2<0)
        {Console.WriteLine(0);}
        else
        {
            
            for(int i=a+1;i<b;i++)
            {
                if(i%2!=0)
                {soma+=i;}
            }
        Console.WriteLine(soma);
        }
    }

}