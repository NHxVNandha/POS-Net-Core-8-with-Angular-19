using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Transactions;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Transactions
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly IRepository<Sale> _saleRepository;

        public SaleController(IRepository<Sale> saleRepository)
        {
            _saleRepository = saleRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sales = await _saleRepository.GetAllAsync();
            return Ok(sales);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var sale = await _saleRepository.GetByIdAsync(id);
            if (sale == null) return NotFound();
            return Ok(sale);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Sale sale)
        {
            await _saleRepository.AddAsync(sale);
            return CreatedAtAction(nameof(GetById), new { id = sale.Id }, sale);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Sale sale)
        {
            if (id != sale.Id) return BadRequest();
            await _saleRepository.UpdateAsync(sale);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _saleRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
