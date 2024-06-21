using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        List<int> listao = new List<int>();
        int count = 0;

        for (int n = 2; count < 3502; n++)
        {
            bool ePrimo =true;
            if (n<2) ePrimo = false;
            if (n==2) ePrimo = true;
            if (n%2 == 0 && n!=2) ePrimo = false;
            int x = (int)Math.Sqrt(n);
            for (int i=3;i<=x;i+= 2)
            {
                if (n%i == 0) 
                {
                    ePrimo = false;
                    break;
                }
            }
            if (ePrimo)
            {
                listao.Add(n);
                count++;
            }
        }

        while (true)
        {
            string a = Console.ReadLine();
            if (int.TryParse(a, out int x) && x > 0)
            {
                int print = 0;
                for (int i=1;i<=x;i++)
                {
                    print = (print+listao[x - i])%i;
                }
                Console.WriteLine(print+1);
            }
            else
            {
                break;
            }
        }

    }

}
