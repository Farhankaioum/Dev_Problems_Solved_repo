using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Console
{
    public class JolyNumber
    {
        public int Number { get; set; }

        public JolyNumber()
        {
            Number = 0;
        }

        public JolyNumber(int number)
        {
            Number = number;
        }

        public virtual void Increment()
        {
            Number++;
        }

        public void Increment(int number)
        {
            Number += number;
        }

    }
}
