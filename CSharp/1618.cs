using System; 
using System.Linq;


class URI {

    static void Main(string[] args) 
    {   
        int n = int.Parse(Console.ReadLine());
        int[] listao;
        int x;
        int y;

        for(int i=0;i<n;i++)
        {
            listao = Console.ReadLine().Split().Select(int.Parse).ToArray();
            x = listao[8];
            y= listao[9];
            if
            (
                listao[0]<=x &&
                listao[1]<=y &&
                listao[2]>=x &&
                listao[3]<=y &&
                listao[4]>=x &&
                listao[5]>=y &&
                listao[6]<=x &&
                listao[7]>=y
            )
            {
                Console.WriteLine(1);
            }
            else{Console.WriteLine(0);}
        }


    }
}
        