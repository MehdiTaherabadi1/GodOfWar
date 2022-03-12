namespace ProductManagement.Domain.Models.Products.ProductConstraint
{
    public class StringConstraint : ProductConstraint
    {
        public long MaxLength { get; set; }
        public string Format { get; set; }

        public StringConstraint(long maxLength, string format)
        {
            MaxLength = maxLength;
            Format = format;
        }
    }
}