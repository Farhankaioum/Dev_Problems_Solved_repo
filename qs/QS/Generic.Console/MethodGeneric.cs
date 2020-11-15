using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Console
{
    public class MethodGeneric
    {
        public void Print<T>(T item)
        {
            System.Console.WriteLine(item);
        }

        public T Add<T, T2, T3>(T item) where T : new()
        {
            var item1 = new T();
            return item1;
        }
    }


}
