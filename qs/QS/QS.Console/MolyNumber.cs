using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Console
{
    public class MolyNumber : JolyNumber
    {
        public override void Increment()
        {
            Number = Number + 2;
        }
    }
}
