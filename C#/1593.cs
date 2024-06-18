using System;
using System.Text;
using System.Numerics;
using System.Linq;


class Program {
    static void Main() {
        BigInteger numero;  
        string print;

        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n;i++)
        {
            StringBuilder binario = new StringBuilder();
            numero=BigInteger.Parse(Console.ReadLine());

            while (numero > 0) {
                binario.Insert(0, numero % 2);
                numero = numero / 2; 
            }
            print=binario.ToString();
            Console.WriteLine(print.Count(x=>x=='1')); 
        }
}
}