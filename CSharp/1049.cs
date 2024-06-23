using System;

class Program
{
    static void Main()
    {
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();
        string a = "";

        if (x == "vertebrado" && y == "ave" && z == "carnivoro")
        {
            a = "aguia";
        }
        else if (x == "vertebrado" && y == "ave" && z == "onivoro")
        {
            a = "pomba";
        }
        else if (x == "vertebrado" && y == "mamifero" && z == "onivoro")
        {
            a = "homem";
        }
        else if (x == "vertebrado" && y == "mamifero" && z == "herbivoro")
        {
            a = "vaca";
        }
        else if (x == "invertebrado" && y == "inseto" && z == "hematofago")
        {
            a = "pulga";
        }
        else if (x == "invertebrado" && y == "inseto" && z == "herbivoro")
        {
            a = "lagarta";
        }
        else if (x == "invertebrado" && y == "anelideo" && z == "hematofago")
        {
            a = "sanguessuga";
        }
        else if (x == "invertebrado" && y == "anelideo" && z == "onivoro")
        {
            a = "minhoca";
        }

        Console.WriteLine(a);
    }
}
