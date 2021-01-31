using System;

namespace DT_1
{
    public class ArrayDemo
    {
        private int[] array;
        private int count = 0;

        public ArrayDemo(int size)
        {
            array = new int[size];
        }

        public void Insert(int value)
        {
            if(array.Length == count)
            {
                var newArray = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
            }

            array[count++] = value;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            count--;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public int IndexOf(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            return array[index];
        }
    }
}
