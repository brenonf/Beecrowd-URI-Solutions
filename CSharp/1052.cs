using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine((Meses)numero);
    }

    enum Meses
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
