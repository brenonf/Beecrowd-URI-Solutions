using System;
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int k;
        int[] lista1;
        int[] lista2;
        int x;
        int y;
        int n;
        int m;

        while(true)
        {
            k = int.Parse(Console.ReadLine());
            if(k == 0)
            {break;}
            lista1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            n=-lista1[0];
            m=-lista1[1];
           
            for(int  i = 0; i < k;i++)
            {
                lista2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                x = lista2[0]+n;
                y = lista2[1]+m;

                if(x==0 || y==0)
                {Console.WriteLine("divisa");}
                else if(x>0 && y>0)
                {Console.WriteLine("NE");}
                else if(x>0 && y<0)
                {Console.WriteLine("SE");}
                else if(x<0 && y>0)
                {Console.WriteLine("NO");}
                else{Console.WriteLine("SO");}

            }

        }

       

    }

}