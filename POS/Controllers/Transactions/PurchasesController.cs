using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Transactions;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Transactions
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : ControllerBase
    {
        private readonly IRepository<Purchase> _purchaseRepository;

        public PurchasesController(IRepository<Purchase> purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var purchases = await _purchaseRepository.GetAllAsync();
            return Ok(purchases);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);
            if (purchase == null) return NotFound();
            return Ok(purchase);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Purchase purchase)
        {
            await _purchaseRepository.AddAsync(purchase);
            return CreatedAtAction(nameof(GetById), new { id = purchase.Id }, purchase);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Purchase purchase)
        {
            if (id != purchase.Id) return BadRequest();
            await _purchaseRepository.UpdateAsync(purchase);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _purchaseRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
