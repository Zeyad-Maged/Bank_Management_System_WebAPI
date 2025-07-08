using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zeyad_maged_3025316.DTOs.AccountDTOs;
using zeyad_maged_3025316.Repositories.Interfaces;

namespace zeyad_maged_3025316.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo _repo;
        public AccountController(IAccountRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddAccount")]
        public IActionResult AccountPost(AccountPostDTO dto, int CustomerId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var res = _repo.AccountPost(dto, CustomerId);
                if (res == false)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
