namespace WarsawApi.Entities
{
    public class CategoryEntity
    {
        public CategoryEntity(int categoryId, string description, int color)
        {
            CategoryId = categoryId;
            Description = description;
            Color = color;
        }
        public CategoryEntity(string description, int color)
        {
            Description = description;
            Color = color;
        }

        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Color { get; set; }
    }
}
