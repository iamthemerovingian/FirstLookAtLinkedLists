﻿

namespace FirstLookAtLinkedLists
{
   

    class LinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head { get; private set; }

        public LinkedListNode<T> Tail { get; private set; }
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
            AddToFront(new LinkedListNode<T>(value));
        }

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

        public void AddLast(T value)
        {
            AddToEnd(new LinkedListNode<T>(value));
        }

        // What if you added a node that was a member of another list and it was not the final node, it's next pointer would lead you to another list entirely.
        // and then you would be enumerating in another list!!! how can you safeguard against this?
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
            if (Count != 0)
            {
                if(Head.Next != null)
                {
                    Head = Head.Next;
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

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> currentNode = Head;
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
            LinkedListNode<T> currentNode = Head;

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
            LinkedListNode<T> currentNode = Head;

            while (currentNode != null)
            {
                array[arrayIndex++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previousNode = null;
            LinkedListNode<T> currentNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    if (previousNode != null)
                    {
                        previousNode.Next = currentNode.Next;

                        if (currentNode.Next == null)
                        {
                            Tail = previousNode;
                        }
                    }
                    else
                    {
                        Remove(item);
                    }

                    return true;
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            return false;
        }
    }
}
