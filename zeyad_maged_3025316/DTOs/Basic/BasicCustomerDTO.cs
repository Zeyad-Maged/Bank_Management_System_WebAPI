using System.ComponentModel.DataAnnotations;
using zeyad_maged_3025316.Models;

namespace zeyad_maged_3025316.DTOs.Basic
{
    public class BasicCustomerDTO
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
