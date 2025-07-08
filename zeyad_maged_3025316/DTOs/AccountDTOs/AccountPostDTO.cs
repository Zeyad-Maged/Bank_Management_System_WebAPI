using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.DTOs.AccountDTOs
{
    public class AccountPostDTO
    {
        [Required]
        [MaxLength(20)]
        public string AccountNumber { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Balance { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}
