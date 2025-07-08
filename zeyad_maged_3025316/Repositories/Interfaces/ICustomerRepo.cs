using zeyad_maged_3025316.DTOs.CustomerDTOs;

namespace zeyad_maged_3025316.Repositories.Interfaces
{
    public interface ICustomerRepo
    {
        public bool CustomerPost(CustomerPostDTO dto);
        public CustomerGetDTO CustomerGet(int Id);
    }
}
