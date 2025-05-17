using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.MasterData;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.MasterData
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly IRepository<Supplier> _supplierRepository;

        public SuppliersController(IRepository<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var suppliers = await _supplierRepository.GetAllAsync();
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var supplier = await _supplierRepository.GetByIdAsync(id);
            if (supplier == null)
                return NotFound();

            return Ok(supplier);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Supplier supplier)
        {
            await _supplierRepository.AddAsync(supplier);
            return CreatedAtAction(nameof(GetById), new { id = supplier.Id }, supplier);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Supplier supplier)
        {
            if (id != supplier.Id)
                return BadRequest();

            await _supplierRepository.UpdateAsync(supplier);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _supplierRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
