using System.ComponentModel.DataAnnotations;
using zeyad_maged_3025316.DTOs.Basic;
using zeyad_maged_3025316.Models;

namespace zeyad_maged_3025316.DTOs.Merged
{
    public class CustomerAccountDTO
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public List<BasicAccountDTO> accounts { get; set; }
    }
}
