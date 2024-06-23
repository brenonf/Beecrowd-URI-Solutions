using System; 

class URI {

    static void Main(string[] args) 
    {
        int par=0;
        int impar=0;
        int positivo=0;
        int negativo=0;
        int num;

        for(int i=0;i<5;i++)
        {
            num = int.Parse(Console.ReadLine());
            if(num%2==0) par++;
            else impar++;

            if(num>0) positivo++;
            else if(num<0) negativo++;
        }
        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{positivo} valor(es) positivo(s)");
        Console.WriteLine($"{negativo} valor(es) negativo(s)");
    }

}