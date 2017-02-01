

namespace FirstLookAtLinkedLists
{
   

    class DoublyLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }

        public DoublyLinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void AddFirst(T value)
        {
            AddToFront(new DoublyLinkedListNode<T>(value));
        }

        public void AddToFront(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
        }

        public void AddLast(T value)
        {
            AddToEnd(new DoublyLinkedListNode<T>(value));
        }

        // What if you added a node that was a member of another list and it was not the final node, it's next pointer would lead you to another list entirely.
        // and then you would be enumerating in another list!!! how can you safeguard against this?
        public void AddToEnd(DoublyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Count++;
            Tail = node;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                if(Head.Next != null)
                {
                    Head = Head.Next;
                    Head.Previous = null;
                }
                else
                {
                    Head = null;
                    Tail = null;
                }
                Count--;
            }
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
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            DoublyLinkedListNode<T> currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoublyLinkedListNode<T> currentNode = Head;

            while (currentNode != null)
            {
                array[arrayIndex++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    if (currentNode.Previous != null)
                    {
                        currentNode.Previous.Next = currentNode.Next;

                        if (currentNode.Next == null)
                        {
                            Tail = currentNode.Previous;
                        }
                        else
                        {
                            currentNode.Next.Previous = currentNode.Previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
    }
}
