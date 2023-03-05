namespace HardCodeApp.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ProductField> Fields { get; set; }
    }
}