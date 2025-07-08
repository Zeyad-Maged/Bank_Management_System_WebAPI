using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public List<Branch> branches { get; set; }
        public List<Account> accounts { get; set; }
        public BankCard BankCard { get; set; }
    }
}
