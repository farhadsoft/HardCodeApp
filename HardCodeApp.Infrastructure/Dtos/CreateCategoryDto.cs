namespace HardCodeApp.Infrastructure.Dtos
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }
        public List<CreateProductFieldDto> Fields { get; set; }
    }
}
