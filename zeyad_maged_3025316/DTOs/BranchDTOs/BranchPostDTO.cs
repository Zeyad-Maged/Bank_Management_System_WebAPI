using System.ComponentModel.DataAnnotations;
using zeyad_maged_3025316.DTOs.Basic;
using zeyad_maged_3025316.Models;

namespace zeyad_maged_3025316.DTOs.BranchDTOs
{
    public class BranchPostDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public List<BasicCustomerDTO>? customers { get; set; }
    }
}
