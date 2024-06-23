using System; 

class URI {

    static void Main(string[] args) 
    {
        int cont=0;
        int num;

        for(int i=0;i<5;i++)
        {
            num = int.Parse(Console.ReadLine());
            if(num%2==0) cont++;
        }
        Console.WriteLine($"{cont} valores pares");
    }

}