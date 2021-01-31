using System;

namespace DT_1
{
    public class LinkedListGeneric<T>
    {
        private class Node
        {
            public T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node _head;
        private Node _tail;
        private int _size;

        public void AddFirst(T value)
        {
            var node = new Node(value);

            if (IsEmpty())
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }

            _size++;

        }

        public void AddLast(T value)
        {
            var node = new Node(value);

            if (IsEmpty())
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            _size++;
        }

        public int IndexOf(T item)
        {
            if (IsEmpty())
                throw new ArgumentNullException();

            int index = 0;
            var current = _head;

            while (current != null)
            {
                if (current.Next.Equals(item))
                    return index;

                current = current.Next;
                index++;
            }

            return index;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if(_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                var second = _head.Next;
                _head.Next = null;
                _head = second;
            }

            _size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                var current = _head;
                while (current != null)
                {
                    if (current.Next.Equals(_tail))
                        break;

                    current = current.Next;
                }

                _tail = current;
                _tail.Next = null;
            }

            _size--;
        }

        public void Reverse()
        {
            Node first = _head, last = _head.Next;
            while (last != null)
            {
                var next = last.Next;
                last.Next = first;
                first = last;
                last = next;
            }

            _tail = _head;
            _tail.Next = null;
            
            _head = first;

        }

        public int Size()
        {
            return _size;
        }

        public T[] ToArray()
        {
            var current = _head;
            var list = new T[_size];
            int index = 0;

            while (current != null)
            {
                list[index++] = current.Value;
                current = current.Next;
            }

            return list;
        }

        public void Print()
        {
            var current = _head;
            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        private bool IsEmpty()
        {
            return _head == null;
        }
    }
}
