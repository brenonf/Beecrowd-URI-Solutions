using System; 

class URI {

    static void Main(string[] args) 
    { 
        string[] frase = Console.ReadLine().Split();
        int n = frase.Length;

        for(int i =0;i<n;i++)
        {
            if(frase[i].Length>=4 && frase[i][0]==frase[i][2] &&frase[i][1]==frase[i][3])
            {
                frase[i] = frase[i].Substring(2,frase[i].Length-2);
            }
        }
        Console.WriteLine(string.Join(" ",frase));
    }

}