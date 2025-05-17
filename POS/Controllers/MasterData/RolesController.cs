using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.MasterData;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.MasterData
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRepository<Role> _roleRepository;

        public RolesController(IRepository<Role> roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleRepository.GetAllAsync();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var role = await _roleRepository.GetByIdAsync(id);
            if (role == null)
                return NotFound();
            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Role role)
        {
            await _roleRepository.AddAsync(role);
            return CreatedAtAction(nameof(GetById), new { id = role.Id }, role);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Role role)
        {
            if (id != role.Id)
                return BadRequest();
            await _roleRepository.UpdateAsync(role);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _roleRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
