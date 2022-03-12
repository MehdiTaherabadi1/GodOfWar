namespace ProductManagement.Domain.Models.Products.ProductConstraint
{
    public class NumberRangeConstraint : ProductConstraint
    {
        public decimal? Main { get; private set; }
        public decimal? Max { get; private set; }

        public NumberRangeConstraint(decimal? main, decimal? max)
        {
            Main = main;
            Max = max;
        }
    }
}