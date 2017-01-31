
namespace FirstLookAtLinkedLists
{
    class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

    class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }

        public LinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddToFront(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            node.Next = temp;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddToEnd(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Count++;
            Tail = node;
        }

        public void RemoveFirst()
        {

        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    LinkedListNode<T> currentNode = Head;

                    while (currentNode.Next != Tail)
                    {
                        currentNode = currentNode.Next;
                    }

                    currentNode.Next = null;
                    Tail = currentNode;
                }

                Count--;
            }
        }
    }
}
