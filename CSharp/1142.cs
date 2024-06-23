using System;


class URI {

    static void Main(string[] args) 
    {
        int aux=1;

        int n = int.Parse(Console.ReadLine());
        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"{aux} {aux+1} {aux+2} PUM");
            aux+=4;
        }
    }

}

