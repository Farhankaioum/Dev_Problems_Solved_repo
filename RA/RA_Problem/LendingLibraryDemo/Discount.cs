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

    public class FixedDiscount : Discount
    {
        public FixedDiscount(double discountAmount) 
            : base(discountAmount)
        {
                
        }


        public override int CalculateDiscount(int orginalPrice)
        {
            double discount = orginalPrice * (discountAmount / 100);
            return (int)discount;

        }
    }

    public class PercentageDiscount : Discount
    {
        public PercentageDiscount(double discountAmount)
            : base(discountAmount)
        {

        }


        public override int CalculateDiscount(int orginalPrice)
        {
            double percentage = (discountAmount / orginalPrice) * 100;
            return (int)percentage;
        }
    }

}
