namespace HardCodeApp.Infrastructure.Dtos
{
    public class UpdateProductDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? PhotoUrl { get; set; }
        public int CategoryId { get; set; }
        public List<ProductFieldDto>? Fields { get; set; }
    }
}
