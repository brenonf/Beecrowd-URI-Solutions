using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        DateTime a = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime b = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        int dif = a.Year - b.Year;

        if (a.Month - b.Month < 0)
        {
            dif--;
        }
        else if (a.Month - b.Month == 0)
        {
            if (a.Day - b.Day < 0)
            {
                dif--;
            }
            else if (a.Day == b.Day)
            {
                Console.WriteLine("Feliz aniversario!");
            }
        }

        Console.WriteLine($"Voce tem {dif} anos {n}.");
    }
}
