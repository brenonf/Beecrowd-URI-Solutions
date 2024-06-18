using System; 


class URI 
{

    static void Main(string[] args) 
    {
        char[] a;
        int soma=1;
        int n = int.Parse(Console.ReadLine());
        int[] print = new int[n];
        for (int i= 0; i < n; i++)
        {
            a = Console.ReadLine().ToCharArray();
            foreach (char c in a)
            {
                if(char.ToLower(c)=='a' || char.ToLower(c)=='e' || char.ToLower(c)=='i' || char.ToLower(c)=='o'  || char.ToLower(c)=='s')
                {
                    soma*=3;
                }
                else{
                    soma*=2;
                }
            }
            print[i]=soma;
            soma=1;

        }
        foreach(int x in print)
        {Console.WriteLine(x);}


    
    }
}
