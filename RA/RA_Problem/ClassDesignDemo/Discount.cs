using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUI
{
    public abstract class Discount
    {
        public double discountAmount;
        public Discount(double discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public abstract int CalculateDiscount(int orginalPrice);
    }

}
