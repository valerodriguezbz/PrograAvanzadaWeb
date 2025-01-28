namespace Abstractions.Models
{
    public class Carts
    {
        public Guid Id { get; set; }
        public int IdUser { get; set; }
        public DateTime? DateCreated { get; set; }
    }

    public class CartsRequest
    {
        public int IdUser { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
