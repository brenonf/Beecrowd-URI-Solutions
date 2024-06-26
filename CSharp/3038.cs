using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        string frase;
        while(true)
        {
            frase = Console.ReadLine();
            if(string.IsNullOrEmpty(frase))
            {break;}

            frase = frase.Replace("@","a").Replace("&","e").Replace("!","i").Replace("*","o").Replace("#","u");
            Console.WriteLine(frase);
        }
    }
}