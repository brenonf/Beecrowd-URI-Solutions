using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lista = new char[4] { 'N', 'L', 'S', 'O' };
            char[] comandos;
            int index = 0;
            string n;

            while (true)
            {
                n = Console.ReadLine();
                if(n=="0") { break; }


                comandos = Console.ReadLine().ToCharArray();

                foreach (char c in comandos)
                {
                    if (c == 'D')
                    {
                        index++;
                        if (index == 4) { index = 0; }
                    }
                    else
                    {
                        index--;
                        if (index == -1)
                        { index = 3; }
                    }
                }
                Console.WriteLine(lista[index]);
                index = 0;
            }
        }
    }
}