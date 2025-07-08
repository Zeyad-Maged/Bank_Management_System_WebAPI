using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.Models
{
    public class Branch
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public List<Customer> customers { get; set; }
    }
}
