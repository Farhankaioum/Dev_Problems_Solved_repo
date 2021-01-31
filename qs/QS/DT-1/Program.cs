namespace DT_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // arraylist
            var arrayDemo = new ArrayDemo(2);
            arrayDemo.Insert(10);
            arrayDemo.Insert(20);
            arrayDemo.Insert(30);
            arrayDemo.Insert(40);

            arrayDemo.RemoveAt(1);

            arrayDemo.Print();
        }
    }
}
