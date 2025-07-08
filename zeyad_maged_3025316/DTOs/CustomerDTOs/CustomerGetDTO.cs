using System.ComponentModel.DataAnnotations;
using zeyad_maged_3025316.DTOs.Basic;

namespace zeyad_maged_3025316.DTOs.CustomerDTOs
{
    public class CustomerGetDTO
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public List<BasicBranchDTO>? branches { get; set; }
        public BasicBankCardDTO? BankCard { get; set; }
    }
}
