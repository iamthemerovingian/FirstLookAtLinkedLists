
using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstLookAtLinkedLists
{
    class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

    class LinkedList<T> : ICollection<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            LinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            RemoveFirst();
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
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
