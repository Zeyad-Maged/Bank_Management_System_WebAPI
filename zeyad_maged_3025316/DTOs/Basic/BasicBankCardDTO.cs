using System.ComponentModel.DataAnnotations;

namespace zeyad_maged_3025316.DTOs.Basic
{
    public class BasicBankCardDTO
    {
        public string CardNumber { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
