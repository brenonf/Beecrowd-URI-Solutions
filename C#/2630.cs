using System; 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 0;
        int aux = 0; 
        
        n = int.Parse(Console.ReadLine());
        
        for (int j = 0; j < n; j++)
        {
            string metodo = Console.ReadLine();
            string[] numeros = Console.ReadLine().Split();
            
            switch (metodo)
            {
                case "min":
                {
                    aux = int.Parse(numeros[0]);
                    for (int i = 1; i < 3; i++)
                    {
                        if (aux > int.Parse(numeros[i]))
                        {
                            aux = int.Parse(numeros[i]);
                        }
                    }       
                    break;
                }
                
                case "max":
                {
                    aux = int.Parse(numeros[0]);
                    for (int i = 1; i < 3; i++)
                    {
                        if (aux < int.Parse(numeros[i]))
                        {
                            aux = int.Parse(numeros[i]);
                        }
                    } 
                    break;
                }
                
                case "mean":
                {
                    int sum = int.Parse(numeros[0]) + int.Parse(numeros[1]) + int.Parse(numeros[2]);
                    
                    aux = (int)(sum / 3);
                    break;
                }
                
                case "eye":
                {
                    int R = int.Parse(numeros[0]);
                    int G = int.Parse(numeros[1]);
                    int B = int.Parse(numeros[2]);
                    float gr = (0.30f * R);
                    float gg = (0.59f * G);
                    float gb = (0.11f * B);

                    aux = (int)(gr + gg + gb);
                    
                    break;
                }
            }
            Console.WriteLine("Caso #{0}: {1}",j+1,aux);
        }
    }
}
