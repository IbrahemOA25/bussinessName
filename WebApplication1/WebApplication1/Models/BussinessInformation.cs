using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class BussinessInformation
    {
        [Required]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Name { get; set; } 
        public string DBA { get; set; }  
        public int AddressId { get; set; }    

    }
}
