using System; 

class URI {

    static void Main(string[] args) 
    {
        char[] msg = Console.ReadLine().ToCharArray();
        char[] crib = Console.ReadLine().ToCharArray();

        int m = msg.Length;
        int c = crib.Length;
        int cont=0;
        int print=0;

        for(int i=0;i<m-c+1;i++)
        {
            for(int j = 0;j<c;j++)
            {
                if(msg[i+j]==crib[j])
                {cont++;}
            }
            if(cont==0)
            {print++;}
            cont=0;
        }
        Console.WriteLine(print);

    }
}