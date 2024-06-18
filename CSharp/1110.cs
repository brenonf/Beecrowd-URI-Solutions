using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder lixo = new StringBuilder();
        Queue<int> queue = new Queue<int>();
        int n;

        while (true)
        {
            n = int.Parse(Console.ReadLine());
            if (n == 0) break;

            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }

            lixo.Clear();
            while (queue.Count > 1)
            {
                lixo.Append(queue.Dequeue() + ", ");
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine("Discarded cards: " + lixo.ToString().TrimEnd(',', ' '));
            Console.WriteLine("Remaining card: " + queue.Peek());
            queue.Clear();
        }
    }
}
