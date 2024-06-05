using System; 

class URI {

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());
        string[] lista = Console.ReadLine().Split();
        int cont = 1;

        int[] num = new int[n-1];

        for(int i = 0; i<n-1; i++)
        {
            num[i] = int.Parse(lista[i+1])-int.Parse(lista[i]);
        }

        for(int i=0; i<n-2;i++)
        {//Console.WriteLine(i);
        if(num[i]!=num[i+1])
        {cont+=1;}
        }
        Console.WriteLine(cont);
    }

}