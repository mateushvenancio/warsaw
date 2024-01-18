namespace WarsawApi.Dto.Category
{
    public class CreateCategoryDto(string description, int color)
    {
        public string Description { get; set; } = description;
        public int Color { get; set; } = color;
    }
}
