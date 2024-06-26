using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) 
    { 
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal numero;
        decimal fracao;
        decimal cutOff;
        string teste;

        while(true)
        {
            teste = Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {break;}
            cutOff = decimal.Parse(Console.ReadLine());
            numero = decimal.Parse(teste);
            fracao = numero - Math.Floor(numero);

            if(fracao>cutOff)
            {
                numero = Math.Ceiling(numero);
            }
            else{numero=Math.Floor(numero);}
            Console.WriteLine((int)numero);
        }

    }

}