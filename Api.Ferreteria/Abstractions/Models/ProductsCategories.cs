namespace Abstractions.Models
{
    public class ProductsCategories
    {
        public Guid IdProduct { get; set; }
        public Guid IdCategory { get; set; }
        public string? Name { get; set; }
    }
}
