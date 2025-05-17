using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.MasterData;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.MasterData
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxController : ControllerBase
    {
        private readonly IRepository<Tax> _taxRepository;

        public TaxController(IRepository<Tax> taxRepository)
        {
            _taxRepository = taxRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var taxes = await _taxRepository.GetAllAsync();
            return Ok(taxes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var tax = await _taxRepository.GetByIdAsync(id);
            if (tax == null)
                return NotFound();
            return Ok(tax);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tax tax)
        {
            await _taxRepository.AddAsync(tax);
            return CreatedAtAction(nameof(GetById), new { id = tax.Id }, tax);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Tax tax)
        {
            if (id != tax.Id)
                return BadRequest();
            await _taxRepository.UpdateAsync(tax);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _taxRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
