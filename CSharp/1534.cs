using System; 
using System.Linq;
using System.Text;

class URI {

    static void Main(string[] args) 
    {
        StringBuilder print = new StringBuilder();
        string entrada;
        int x;
        int um;
        int dois;

        while(true)
        {
            entrada = Console.ReadLine();
            if(string.IsNullOrEmpty(entrada))
            {
                break;
            }

            x=int.Parse(entrada);
            um =0;
            dois=x-1;

            for(int i = 0;i<x;i++)
            {
                for(int j =0;j<x;j++)
                {
                    if(j==dois)
                    {
                        print.Append("2");
                    }
                    else if(j==um)
                    {
                        print.Append("1");
                    }
                    else{print.Append("3");}
                }
                Console.WriteLine(print);
                print.Clear();
                um++;
                dois--;
            }

        }
    }

}