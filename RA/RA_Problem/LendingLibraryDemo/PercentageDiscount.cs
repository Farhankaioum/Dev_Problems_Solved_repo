namespace ExampleUI
{
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
