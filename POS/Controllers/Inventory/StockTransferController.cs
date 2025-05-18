using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Inventory;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Inventory
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockTransferController : ControllerBase
    {
        private readonly IRepository<StockTransfer> _transferRepository;

        public StockTransferController(IRepository<StockTransfer> transferRepository)
        {
            _transferRepository = transferRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var transfers = await _transferRepository.GetAllAsync();
            return Ok(transfers);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var transfer = await _transferRepository.GetByIdAsync(id);
            if (transfer == null) return NotFound();
            return Ok(transfer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StockTransfer transfer)
        {
            await _transferRepository.AddAsync(transfer);
            return CreatedAtAction(nameof(GetById), new { id = transfer.Id }, transfer);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, StockTransfer transfer)
        {
            if (id != transfer.Id) return BadRequest();
            await _transferRepository.UpdateAsync(transfer);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _transferRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
