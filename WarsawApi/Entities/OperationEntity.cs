namespace WarsawApi.Entities
{
    public class OperationEntity
    {
        public OperationEntity(string? description, decimal value, CategoryEntity category, DateTime date)
        {
            Description = description;
            Value = value;
            Category = category;
            Date = date;
        }

        public OperationEntity(int id, string? description, decimal value, CategoryEntity category, DateTime date)
        {
            OperationId = id;
            Description = description;
            Value = value;
            Category = category;
            Date = date;
        }

        public int OperationId { get; set; }
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public CategoryEntity Category { get; set; }
        public DateTime Date { get; set; }
    }
}
