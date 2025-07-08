using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zeyad_maged_3025316.DTOs.BranchDTOs;
using zeyad_maged_3025316.Repositories.Interfaces;

namespace zeyad_maged_3025316.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepo _repo;
        public BranchController(IBranchRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddBranch")]
        public IActionResult BranchPost(BranchPostDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _repo.BranchPost(dto);
            return Ok();
        }

        [HttpGet("GetBranches")]
        public IActionResult BranchGet()
        {
            var get = _repo.BranchGet();
            if (get == null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpPut("UpdateBranch")]
        public IActionResult BranchPut(BranchPutDTO dto, int Id)
        {
            var put = _repo.BranchPut(dto, Id);
            if (put == false)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("DeleteBranch")]
        public IActionResult BranchDelete(int Id)
        {
            var delete = _repo.BranchDelete(Id);
            if (delete == false)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
