using System; 


class URI {

    static void Main(string[] args) 
    {
        int x = 7;
        for(int i=1;i<10;i+=2)
        {
            for (int j=x;j>x-3;j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            x+=2;
        }
    }

}

