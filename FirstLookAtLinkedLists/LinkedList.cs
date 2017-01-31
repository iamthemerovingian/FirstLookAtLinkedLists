
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
                AddToFront(node);
            }
            else
            {
                Count++;
                Tail.Next = node;
                Tail = node;
            }
        }
    }
}
