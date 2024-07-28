using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        //Dictionary<string,string> dic = new Dictionary<string,string>();
        HashSet<string> listao = new HashSet<string>();
        int cont=0;
        string[] email;
        string nome;


        for(int i =0;i<n;i++)
        {
            email = Console.ReadLine().Split('@');
            nome=email[0].Replace(".","").Split('+')[0]+"@"+email[1];
            //Console.WriteLine(nome);
            if(!listao.Contains(nome))
            {
                listao.Add(nome);
            }
        }
        Console.WriteLine(listao.Count);
    }

}