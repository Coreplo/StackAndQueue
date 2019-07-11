using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack - LiFo collection");

            /*
             stack properties
             Count

            stack methods
            Peek() return the element at the top ofthe stack but without popping it
            Pop() return top element and remove it
            Push(T t) insert t at the top of the stack
            Clear()
            Contains()
            ToArray()
             */

            Stack<int> s = new Stack<int>();

            s.Push(42);
            s.Push(22);
            s.Push(12);
            s.Push(32);
            s.Push(02);

            Console.Write("Stack: ");
            foreach (int i in s)
                Console.Write(i + " ");  
            Console.Write("\nCount: " + s.Count);

            Console.Write("\nTop: " + s.Peek());  
            Console.Write("\nPop: " + s.Pop());  

            Console.Write("\nStack: ");
            foreach (int i in s)
                Console.Write(i + " ");  
            Console.Write("\nCount: " + s.Count);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Queue - FiFo collection");
            /*
             queue - FiFo collections
             actions: Enqueue and Dequeue

             */

            Queue<int> q = new Queue<int>();

            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 5  10  15
            Console.Write("\nCount: " + q.Count);  // 3

            Console.Write("\nDequeue: " + q.Dequeue()); // 5

            Console.Write("\nQueue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10  15
            Console.Write("\nCount: " + q.Count);  // 2

            Console.ReadKey();

        }
    }
}
