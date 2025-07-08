using zeyad_maged_3025316.DTOs.Basic;
using zeyad_maged_3025316.DTOs.BranchDTOs;

namespace zeyad_maged_3025316.Repositories.Interfaces
{
    public interface IBranchRepo
    {
        public bool BranchPost(BranchPostDTO dto);
        public List<BranchGetDTO> BranchGet();
        public bool BranchPut(BranchPutDTO dto, int Id);
        public bool BranchDelete(int Id);
    }
}
