using System;

namespace DT_1
{
    public class LinkedListDemo
    {
        public class Node
        {
            public object Value { get; set; }
            public Node Next { get; set; }

            public Node(object value)
            {
                Value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        public void AddFirst(object item)
        {
            var node = new Node(item);

            if(IsEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                node.Next = first;
                first = node;
            }

            size++;
        }

        public void AddLast(object item)
        {
            var node = new Node(item);

            if(IsEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                last.Next = node;
                last = node;
            }

            size++;
        }

        public int IndexOf(object item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    return index;

                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(object item)
        {
            //int index = 0;
            //var current = first;

            //while (current != null)
            //{
            //    if (current.Value.Equals(item))
            //        return true;

            //    current = current.Next;
            //    index++;
            //}

            //return false;

            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            if(IsEmpty())
                throw new InvalidOperationException();

            if(first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                var second = first.Next;
                first.Next = null;
                first = second;
            }

            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if(first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                var current = first;

                while (current != null)
                {
                    if (current.Next.Equals(last))
                        break;

                    current = current.Next;
                }

                current.Next = null;
                last = current;
                //last.Next = null;
            }

            size--;
        }

        public void Reverse()
        {
            if (IsEmpty())
                return;

            Node previous = first, current = first.Next;
            while (current != null)
            {
                var next = current.Next; // 2nd node ref
                current.Next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.Next = null;
            first = previous; 
        }

        public int Size()
        {
            return size;
        }

        private bool IsEmpty()
        {
            return first == null;
        }
    }
}
