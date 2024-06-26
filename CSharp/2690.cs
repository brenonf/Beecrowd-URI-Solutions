using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class URI {

    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        string frase;
        StringBuilder senha = new StringBuilder();

        Dictionary<char, int> dic = new Dictionary<char, int>
        {
            {'G', 0}, {'Q', 0}, {'a', 0}, {'k', 0}, {'u', 0},
            {'I', 1}, {'S', 1}, {'b', 1}, {'l', 1}, {'v', 1},
            {'E', 2}, {'O', 2}, {'Y', 2}, {'c', 2}, {'m', 2}, {'w', 2},
            {'F', 3}, {'P', 3}, {'Z', 3}, {'d', 3}, {'n', 3}, {'x', 3},
            {'J', 4}, {'T', 4}, {'e', 4}, {'o', 4}, {'y', 4},
            {'D', 5}, {'N', 5}, {'X', 5}, {'f', 5}, {'p', 5}, {'z', 5},
            {'A', 6}, {'K', 6}, {'U', 6}, {'g', 6}, {'q', 6},
            {'C', 7}, {'M', 7}, {'W', 7}, {'h', 7}, {'r', 7},
            {'B', 8}, {'L', 8}, {'V', 8}, {'i', 8}, {'s', 8},
            {'H', 9}, {'R', 9}, {'j', 9}, {'t', 9}
        };

        for(int i =0;i<n;i++)
        {
            frase=Console.ReadLine().Replace(" ","");
            foreach(char c in frase)
            {
                senha.Append(dic[c].ToString());
                if(senha.Length==12)
                {break;}
            }
            Console.WriteLine(senha);
            senha.Clear();
        }
    }
}