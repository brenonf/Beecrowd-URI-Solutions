using System; 

class URI {

    static void Main(string[] args) 
    {
        char x;
        int a=0;
        int g=0;
        int d=0;
        bool brecar = true;

        while(brecar)
        {
            x = char.Parse(Console.ReadLine());
            switch(x)
            {
                case '1':
                    a++;
                    break;

                case '2':
                    g++;
                    break;

                case '3':
                    d++;
                    break;
                
                case '4':
                    brecar=false;
                    break;

                default:
                    break;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {a}");
        Console.WriteLine($"Gasolina: {g}");
        Console.WriteLine($"Diesel: {d}");

    }
}