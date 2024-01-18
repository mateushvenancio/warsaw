namespace WarsawApi.Dto.Operation
{
    public class CreateOperationDto
    {
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public int CategoryId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
