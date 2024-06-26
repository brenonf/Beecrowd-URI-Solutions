using System;
using System.Text;
using System.Globalization;

class URI 
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        char[] a = Console.ReadLine().ToCharArray();
        char[] b = Console.ReadLine().ToCharArray();
        decimal soma=0;
        StringBuilder cpf=new StringBuilder();
        StringBuilder restoA=new StringBuilder();
        string bFinal;
        int cont=0;
        

        Limpadora(a);
        Limpadora(b);


        while(cpf.Length<11)
        {
            if(a[cont]!=' ')
            {cpf.Append(a[cont]);}
            cont++;
            
        }

        for(int i=cont; i<a.Length;i++)
        {
            if(a[cont]!=' ')
            {restoA.Append(a[cont]);}
            cont++;
        }

        decimal primeiro = Math.Truncate(decimal.Parse(restoA.ToString())*100)/100;
        decimal segundo = Math.Truncate(decimal.Parse(string.Join("",b).Replace(" ",""))*100)/100;

        



        //soma = decimal.Parse($"{restoA.ToString():F2}")+decimal.Parse($"{string.Join("",b).Replace(" ",""):F2}");
        Console.WriteLine($"cpf {cpf}");
        Console.WriteLine($"{primeiro+segundo:F2}");
    }

    private static void Limpadora(char[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != '.' && !char.IsDigit(x[i]))
            {
                x[i] = ' ';
            }
        }
    }
}
