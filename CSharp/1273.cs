using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {   
        bool flag = true;
        while(true)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 0)
            {
                break;
            }

            if(!flag)
            {
                Console.WriteLine();
            }
            flag = false;

            string[] lista = new string[n];
            for(int i = 0; i < n; i++)
            {
                lista[i] = Console.ReadLine();
            }
            int max = lista.Max(s => s.Length);

            for(int i = 0; i < n; i++)
            {   
                lista[i] = lista[i].PadLeft(max, ' ');
            }

            foreach(string s in lista)
            {
                Console.WriteLine(s);
            }
        }        
    }
}
