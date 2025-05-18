using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Inventory;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Inventory
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockAdjustmentController : ControllerBase
    {
        private readonly IRepository<StockAdjustment> _adjustmentRepository;

        public StockAdjustmentController(IRepository<StockAdjustment> adjustmentRepository)
        {
            _adjustmentRepository = adjustmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var adjustments = await _adjustmentRepository.GetAllAsync();
            return Ok(adjustments);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var adjustment = await _adjustmentRepository.GetByIdAsync(id);
            if (adjustment == null) return NotFound();
            return Ok(adjustment);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StockAdjustment adjustment)
        {
            await _adjustmentRepository.AddAsync(adjustment);
            return CreatedAtAction(nameof(GetById), new { id = adjustment.Id }, adjustment);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, StockAdjustment adjustment)
        {
            if (id != adjustment.Id) return BadRequest();
            await _adjustmentRepository.UpdateAsync(adjustment);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _adjustmentRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
