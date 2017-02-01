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
            //LinkedList<int> myFirstLinkedList = new LinkedList<int>();
            //LinkedList<int> mySecondLinkedList = new LinkedList<int>();

            //LinkedListNode<int> nodeOne = new LinkedListNode<int>(1);
            //LinkedListNode<int> nodeTwo = new LinkedListNode<int>(2);
            //LinkedListNode<int> nodeThree = new LinkedListNode<int>(3);

            //myFirstLinkedList.AddToFront(nodeOne);
            //myFirstLinkedList.AddToFront(nodeTwo);
            //myFirstLinkedList.AddToFront(nodeThree);

            //Console.WriteLine("Count is: " + myFirstLinkedList.Count);

            //mySecondLinkedList.AddToEnd(nodeOne);
            //mySecondLinkedList.AddToEnd(nodeTwo);
            //mySecondLinkedList.AddToEnd(nodeThree);

            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);

            //mySecondLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);

            //mySecondLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);
            //mySecondLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + mySecondLinkedList.Count);

            //foreach (var item in mySecondLinkedList)
            //{
            //    Console.WriteLine(item);
            //}

            DoublyLinkedListNode<int> Node1 = new DoublyLinkedListNode<int>(1);
            DoublyLinkedListNode<int> Node2 = new DoublyLinkedListNode<int>(2);
            DoublyLinkedListNode<int> Node3 = new DoublyLinkedListNode<int>(3);

            DoublyLinkedList<int> myFirstDoublyLinkedList = new DoublyLinkedList<int>();

            //myFirstDoublyLinkedList.AddToFront(Node1);
            //myFirstDoublyLinkedList.AddToFront(Node2);
            //myFirstDoublyLinkedList.AddToFront(Node3);

            //myFirstDoublyLinkedList.AddToEnd(Node1);
            //myFirstDoublyLinkedList.AddToEnd(Node2);
            //myFirstDoublyLinkedList.AddToEnd(Node3);

            //myFirstDoublyLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + myFirstDoublyLinkedList.Count);

            //myFirstDoublyLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + myFirstDoublyLinkedList.Count);

            //myFirstDoublyLinkedList.RemoveFirst();
            //Console.WriteLine("Count is: " + myFirstDoublyLinkedList.Count);

            myFirstDoublyLinkedList.AddToEnd(Node1);
            myFirstDoublyLinkedList.AddToEnd(Node2);
            myFirstDoublyLinkedList.AddToEnd(Node3);

            //myFirstDoublyLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + myFirstDoublyLinkedList.Count);

            //myFirstDoublyLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + myFirstDoublyLinkedList.Count);

            //myFirstDoublyLinkedList.RemoveLast();
            //Console.WriteLine("Count is: " + myFirstDoublyLinkedList.Count);

            myFirstDoublyLinkedList.Remove(1);
        }
    }
}
