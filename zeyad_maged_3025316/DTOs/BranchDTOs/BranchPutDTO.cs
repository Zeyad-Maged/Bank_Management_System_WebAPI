using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.DTOs.BranchDTOs
{
    public class BranchPutDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public List<int>? CustomerIDs { get; set; }
    }
}
