using System; 
using System.Linq;


class URI {

    static void Main(string[] args) 
    {   
        int[] lista;
        int[] a;
        int[] d;
        bool  impedido=false;

        while (true) 
        {
            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(lista[0]==0 && lista[1]==0)
            {break;}

            a=Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToArray();
            d=Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToArray();

            foreach(int i in a)
            {
                if((i<d[d.Length-2] && i<d[d.Length-1]) ||(i<d[d.Length-2]))
                {
                    Console.WriteLine("Y");
                    impedido =true;
                    break;
                }
                
            }
            if(!impedido)
            {Console.WriteLine("N");}
            impedido=false;
        }
    }
}