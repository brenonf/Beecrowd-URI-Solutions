using System; 
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    { 
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int[] listao;
        int[] n;
        int cont=0;

        while(true)
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0)
            {break;}
            listao = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach(int i in listao)
            {
                if(dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic[i]=1;
                }
            }
            foreach(var x in dic.Values)
            {
                if(x>=n[1])
                {cont++;}
            }
            Console.WriteLine(cont);
            cont=0;
            dic.Clear();
        }
    }
}