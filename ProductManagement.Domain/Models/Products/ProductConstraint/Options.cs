namespace ProductManagement.Domain.Models.Products.ProductConstraint
{
    public class Options
    {
        public string Title { get; set; }
        public long Value { get; set; }

        public Options(string title, long value)
        {
            Title = title;
            Value = value;
        }
    }
}