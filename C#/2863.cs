using System;
using System.Globalization; 

class Program
{
    static void Main(string[] args)
    {

while (true)
{
    string x = Console.ReadLine();
    if (x == null)
    { break; }
    float aux = 15.000f;

    int n = int.Parse(x);

    for (int i = 0; i < n; i++)
    {
        float t = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //Console.WriteLine(t + " T");
        if (t < aux)
        { aux = t; }

    }
    Console.WriteLine(aux);

}
    }
}