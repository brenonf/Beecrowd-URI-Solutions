using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string a = Console.ReadLine();
            if(string.IsNullOrEmpty(a))
            {
                break;
            }
            
            if(a == "esquerda")
            {
                Console.WriteLine("ingles");
            }
            else if(a == "direita")
            {
                Console.WriteLine("frances");
            }
            else if(a == "nenhuma")
            {
                Console.WriteLine("portugues");
            }
            else if(a == "as duas")
            {
                Console.WriteLine("caiu");
            }
        }
    }
}
