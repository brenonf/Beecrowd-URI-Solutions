using System; 

class URI 
{

    static void Main(string[] args) 
    {
        int n;

        while(true)
        {
            n=int.Parse(Console.ReadLine());
            if(n==2002)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else{Console.WriteLine("Senha Invalida");}
        }
    }
}