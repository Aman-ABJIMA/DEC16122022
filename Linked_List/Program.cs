using System;
using System.Collections.Generic;

namespace Linked_List
{
    class program
    {
        public static void Main(string[] args)
        {
            const int Limit = 5;
            int pesengers = 6;

            string end = "Jhansi";

            Queue<int> peopleWaiting = new Queue<int>();

            for (int i = 0; i < pesengers; i++)
            {
                Console.WriteLine($"{i + 1} queuing at bus stop");
                peopleWaiting.Enqueue(i + 1);
            }

            int a = 0;
            Stack<int> pesenger = new Stack<int>();
            Console.WriteLine("\nBus arriving at bus stop to load passengers");
            int p = 1;
            while (peopleWaiting.Count > 0)
            {
                peopleWaiting.Dequeue();
                if (p <= 5)
                {

                    pesenger.Push(p);
                    Console.WriteLine($"{p} got on the bus");
                    p++;

                }
                else
                {
                    break;
                }
            }

            LinkedList<int> _passengers = new LinkedList<int>();
            p = 1;

            while (p <= 5)
            { 
                _passengers.AddLast(p);
                Console.WriteLine($"{p} got on the bus");
                p++;
            }
           
            
        
       
        
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (_passengers.Count == 0)
                return;

            LinkedListNode<Passenger> currentNode = _passengers.First;
            do
            {
                LinkedListNode<Passenger> nextNode = currentNode.Next;
                if (currentNode.Value.Destination == place)
                {
                    Console.WriteLine($"{currentNode.Value} is getting off");
                    _passengers.Remove(currentNode);
                }
                currentNode = nextNode;
            } while (currentNode != null);
            Console.WriteLine($"{_passengers.Count} people left on the bus");

            //int count = pesenger.Count;

            //Console.WriteLine($"\r\nBus arriving at terminus");
            //while (count > 0)
            //{
            //    pesenger.Pop();
            //    Console.WriteLine($"{count} got off the bus");
            //    count--;
            //}

            //Console.WriteLine($"There are {pesenger.Count} people still on the bus");
        }
    }
}