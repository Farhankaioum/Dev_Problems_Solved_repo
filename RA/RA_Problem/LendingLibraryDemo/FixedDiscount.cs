namespace ExampleUI
{
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

}
