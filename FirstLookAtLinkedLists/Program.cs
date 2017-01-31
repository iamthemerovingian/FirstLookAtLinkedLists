using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLookAtLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myFirstLinkedList = new LinkedList<int>();
            LinkedList<int> mySecondLinkedList = new LinkedList<int>();

            LinkedListNode<int> nodeOne = new LinkedListNode<int>() { Value = 1 };
            LinkedListNode<int> nodeTwo = new LinkedListNode<int>() { Value = 2 };
            LinkedListNode<int> nodeThree = new LinkedListNode<int>() { Value = 3 };

            //myFirstLinkedList.AddToFront(nodeOne);
            //myFirstLinkedList.AddToFront(nodeTwo);
            //myFirstLinkedList.AddToFront(nodeThree);

            //Console.WriteLine("Count is: " + myFirstLinkedList.Count);

            mySecondLinkedList.AddToEnd(nodeOne);
            mySecondLinkedList.AddToEnd(nodeTwo);
            mySecondLinkedList.AddToEnd(nodeThree);

            Console.WriteLine("Count is: " + mySecondLinkedList.Count);

            mySecondLinkedList.RemoveLast();
            Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            mySecondLinkedList.RemoveLast();
            Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            mySecondLinkedList.RemoveLast();
            Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            mySecondLinkedList.RemoveLast();
            Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            mySecondLinkedList.RemoveLast();
            Console.WriteLine("Count is: " + mySecondLinkedList.Count);

        }
    }
}
