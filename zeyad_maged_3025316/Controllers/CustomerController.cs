using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zeyad_maged_3025316.DTOs.CustomerDTOs;
using zeyad_maged_3025316.Repositories.Interfaces;

namespace zeyad_maged_3025316.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _repo;
        public CustomerController(ICustomerRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddCustomer")]
        public IActionResult CustomerPostDTO(CustomerPostDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.CustomerPost(dto);
                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet("{Id}")]
        public IActionResult CustomerGetDTO(int Id)
        {
            var customer = _repo.CustomerGet(Id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
