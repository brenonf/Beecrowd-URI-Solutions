using System;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    { 
        int n;
        string teste;
        var lista = new List<string>();
        int total=0;

        while(true)
        {
            teste = Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {
                break;
            }
            n=int.Parse(teste);

            for(int i=0; i<n;i++)
            {
                lista.Add(Console.ReadLine());
            }

            lista.Sort();

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i][3] == 'D')
                {
                    for (int j = i + 1; j < lista.Count; j++)
                    {
                        if (lista[i][0] == lista[j][0] && lista[i][1] == lista[j][1] && lista[j][3] == 'E')
                        {
                            total++;
                            lista.RemoveAt(i);
                            lista.RemoveAt(j - 1);
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = i + 1; j < lista.Count; j++)
                    {
                        if (lista[i][0] == lista[j][0] && lista[i][1] == lista[j][1] && lista[j][3] == 'D')
                        {
                            total++;
                            lista.RemoveAt(i);
                            lista.RemoveAt(j - 1);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(total);
            total=0;
            lista.Clear();
        }
    }
}
