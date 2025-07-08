using zeyad_maged_3025316.DTOs.AccountDTOs;

namespace zeyad_maged_3025316.Repositories.Interfaces
{
    public interface IAccountRepo
    {
        public bool AccountPost(AccountPostDTO dto, int CustomerId);
    }
}
