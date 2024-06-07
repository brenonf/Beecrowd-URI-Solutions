using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string placa;
        byte a;
        byte b;
        byte c;
        byte d;
        byte e;
        byte f;
        byte g;

        for(int i =0;i<n;i++)
        {   
            
            placa =Console.ReadLine();
            if(placa.Length !=8)
            {Console.WriteLine("FAILURE");}
            else
            {
            a = Convert.ToByte(placa[0]);
            b = Convert.ToByte(placa[1]);
            c = Convert.ToByte(placa[2]);

            d = Convert.ToByte(placa[4]);
            e = Convert.ToByte(placa[5]);
            f = Convert.ToByte(placa[6]);
            g = Convert.ToByte(placa[7]);
            

            if(placa[3]!='-')
            {Console.WriteLine("FAILURE");}

            else if
            (
                (a<65 || a>90) ||
                (b<65 || b>90) ||
                (c<65 || c>90)
            )
            {Console.WriteLine("FAILURE");}

            else if
            (
                (d<48 || d>57) ||
                (e<48 || e>57) ||
                (f<48 || f>57) ||
                (g<48 || g>57)
            )
            {Console.WriteLine("FAILURE");}

            else if(placa[7]=='1' || placa[7]=='2')
            {Console.WriteLine("MONDAY");}

            else if(placa[7]=='3' || placa[7]=='4')
            {Console.WriteLine("TUESDAY");}

            else if(placa[7]=='5' || placa[7]=='6')
            {Console.WriteLine("WEDNESDAY");}

            else if(placa[7]=='7' || placa[7]=='8')
            {Console.WriteLine("THURSDAY");}

            else if(placa[7]=='9' || placa[7]=='0')
            {Console.WriteLine("FRIDAY");}
            }



        }
        
    }
}
//byte asciiValue = Convert.ToByte(character);