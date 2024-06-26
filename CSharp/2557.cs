using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        string entrada;
        string[] numeros;

        while (true)
        {
            entrada = Console.ReadLine();
            if(string.IsNullOrEmpty(entrada))
            {break;}

            numeros =entrada.Split(new char[]{'+','='});

            if(!numeros[0].All(char.IsDigit))
            {
                Console.WriteLine(int.Parse(numeros[2])-int.Parse(numeros[1]));
            }
            else if(!numeros[1].All(char.IsDigit))
            {
                Console.WriteLine(int.Parse(numeros[2])-int.Parse(numeros[0]));
            }
            else
            {
                Console.WriteLine(int.Parse(numeros[0])+int.Parse(numeros[1]));
            }
        }
    }

}