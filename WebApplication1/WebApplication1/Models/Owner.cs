namespace WebApplication1.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int SSN { get; set; } 
        public string DOB { get; set; }
        public bool isActivated { get; set; }   
        public int? BussnessId { get; set; }

    }
}
