namespace W26Week13FinalExamReview.Models
{
    public class Category
    {
        // scalar properties
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        // navigation property
        public ICollection<Product>? Products { get; set; }
    }
}
