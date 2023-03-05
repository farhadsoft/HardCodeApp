using Microsoft.EntityFrameworkCore;

namespace HardCodeApp.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public string? PhotoUrl { get; set; }
        public int CategoryId { get; set; }
        public List<ProductField>? Fields { get; set; }
    }
}
