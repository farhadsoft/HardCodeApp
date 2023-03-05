using HardCodeApp.Domain.Entities;

namespace HardCodeApp.Infrastructure.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductField> Fields { get; set; }
    }
}
