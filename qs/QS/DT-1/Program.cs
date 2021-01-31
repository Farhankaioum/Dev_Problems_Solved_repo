using System;

namespace DT_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //custom generic linked list
            var genericLinkedList = new LinkedListGeneric<int>();
            genericLinkedList.AddLast(10);
            genericLinkedList.AddLast(20);
            genericLinkedList.AddLast(30);
            genericLinkedList.AddLast(40);
            genericLinkedList.RemoveLast();

            var array = genericLinkedList.ToArray();

            genericLinkedList.Print();
            Console.WriteLine();
            genericLinkedList.Reverse();
            genericLinkedList.Print();

            //linklist
            //var list = new LinkedListDemo();
            ////Console.WriteLine(list.Size());
            //list.AddLast(10);
            ////Console.WriteLine(list.Size());
            //list.AddLast(20);
            //list.AddLast(30);
            ////Console.WriteLine(list.Size());
            ////list.RemoveLast();
            //list.RemoveLast();
            ////Console.WriteLine(list.Size());
            //Console.WriteLine(list.Contains(30));
            //list.Reverse();

            //LinkedList<string> list1 = new LinkedList<string>();
            

            // arraylist
            var arrayDemo = new ArrayDemo(2);
            arrayDemo.Insert(10);
            arrayDemo.Insert(20);
            arrayDemo.Insert(30);
            arrayDemo.Insert(40);

            arrayDemo.RemoveAt(1);

            //arrayDemo.Print();
        }
    }
}
