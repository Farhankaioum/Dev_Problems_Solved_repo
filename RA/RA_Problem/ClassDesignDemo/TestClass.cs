using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUI
{
    public static class TestClass
    {
        public static (string name, int age, double weight) DoSomething()
        {
            return ("John", 32, 62.4);
        }
    }
}
