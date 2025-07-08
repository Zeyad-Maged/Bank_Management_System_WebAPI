using System.ComponentModel.DataAnnotations;
using System.Data;

namespace zeyad_maged_3025316.Models
{
    
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string AccountNumber { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Balance { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
