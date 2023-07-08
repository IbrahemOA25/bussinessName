namespace WebApplication1.Models
{
    public class BusinessOwnerAndRatio
    {
        public int Id { get; set; } 
        public int Ratio { get; set; } 
        public int BusinessId { get; set; } 
        public int OwnerId { get; set; }
        public string? Details { get; set; }

    }
}
