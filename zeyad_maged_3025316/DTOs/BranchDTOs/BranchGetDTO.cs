using System.ComponentModel.DataAnnotations;
using zeyad_maged_3025316.DTOs.Merged;

namespace zeyad_maged_3025316.DTOs.BranchDTOs
{
    public class BranchGetDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public List<CustomerAccountDTO> customerAccount { get; set; }
    }
}
