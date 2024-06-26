using System; 
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    {
        List<int> indices = new List<int>();
        int x=0;
        string palavra;
        string p1;
        string p2;

        int n = int.Parse(Console.ReadLine());
        for(int i = 0;i<n;i++)
        {
            p1 = Console.ReadLine();
            p2 = Console.ReadLine();
            palavra = Console.ReadLine();
        
            x = palavra.IndexOf('_');
            while (x != -1 || indices.Count!=2)
            {
                indices.Add(x);
                x = palavra.IndexOf('_', x + 1);
            }

            if(p1[indices[0]]==p2[indices[1]] || p1[indices[1]]==p2[indices[0]])
            {
                Console.WriteLine("Y");
            }
            else{
                Console.WriteLine("N");
            }
            indices.Clear();
        }

    }
}