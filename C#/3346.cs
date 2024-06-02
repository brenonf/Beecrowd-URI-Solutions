using System; 

class URI 
{

    static void Main(string[] args) 
    { 
        double n = 1.00;

        string[] porcentagem= Console.ReadLine().Split();
        n = n*(1+Convert.ToDouble(porcentagem[0])/100);
         n = n*(1+Convert.ToDouble(porcentagem[1])/100);
         Console.WriteLine("{0:F6}",(n-1)*100);

    }

}