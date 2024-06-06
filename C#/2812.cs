using System;
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 
      
        int c = int.Parse(Console.ReadLine());

        while (c-- > 0) {
            int n = int.Parse(Console.ReadLine());
            List<int> impares = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 != 0).ToList();
            impares.Sort();

            List<int> vet1 = new List<int>(impares);
            List<int> vet2 = new List<int>(impares);
            vet2.Sort((a, b) => b.CompareTo(a));

            int k = 0, z = 0;
            bool flag = false;
            for (int i = 0; i < impares.Count; i++) {
                if (i % 2 == 0) {
                    if (flag)
                        Console.Write(" " + vet2[k++]);
                    else
                        Console.Write(vet2[k++]);
                    flag = true;
                } else {
                    if (flag)
                        Console.Write(" " + vet1[z++]);
                    else
                        Console.Write(vet1[z++]);
                    flag = true;
                }
            }
            Console.WriteLine();
        }   
    }
}
