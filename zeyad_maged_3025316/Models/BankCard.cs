using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.Models
{
    public class BankCard
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(16)]
        public string CardNumber { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
