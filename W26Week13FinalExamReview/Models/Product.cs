namespace W26Week13FinalExamReview.Models
{
    public class Product
    {
        // scalar properties
        public int ProductId { get; set; }  // primary key
        public string? ProductName { get; set; }
        public double? Price { get; set; }
        public bool? IsDiscontinued { get; set; }
        public int? CategoryId { get; set; }  // foreign key

        // navigation property
        public Category? Category { get; set; }
    }
}
