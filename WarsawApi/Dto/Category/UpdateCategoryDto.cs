namespace WarsawApi.Dto.Category
{
    public class UpdateCategoryDto(int categorId, string? description, int? color)
    {
        public int CategoryId { get; set; } = categorId;
        public string? Description { get; set; } = description;
        public int? Color { get; set; } = color;
    }
}
