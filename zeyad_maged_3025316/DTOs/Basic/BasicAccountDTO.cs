using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.DTOs.Basic
{
    public class BasicAccountDTO
    {
        [Required]
        [MaxLength(20)]
        public string AccountNumber { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Balance { get; set; }
    }
}
