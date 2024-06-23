using System;
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int[] n;

        while (true) 
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0)
            {break;}

            int pts = 0;
            for(int i=0;i<n[0];i++)
            {
             pts+= int.Parse(Console.ReadLine().Split()[1]);

            }

            if(pts==3*n[1])
            {
                Console.WriteLine(0);
            }
            else{Console.WriteLine(3*n[1]-pts);}
        }
            

    }

}