using System; 

class URI {

    static void Main(string[] args) 
    {   
        int k;
        int n = int.Parse(Console.ReadLine());
        string[] lista = new string[4]{"Rolien","Naej","Elehcim","Odranoel"};

        for(int i=0;i<n;i++)
        {
            k =int.Parse(Console.ReadLine());
            for(int j=0;j<k;j++)
            {
                Console.WriteLine(lista[int.Parse(Console.ReadLine())-1]);
            }
        }

        

    }

}