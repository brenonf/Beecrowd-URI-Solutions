using System; 
using System.Globalization;

class URI 
{

    static void Main(string[] args) 
    { 

        string letra = Console.ReadLine();
        string[] frase = Console.ReadLine().Split();
        int cont=0;

        foreach (string palavra in frase)
        {
            if(palavra.Contains(letra))
            {cont++;}
        }
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        Console.WriteLine($"{(100*(decimal)cont/frase.Length):F1}");

    }
}