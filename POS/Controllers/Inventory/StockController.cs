using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Inventory;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Inventory
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IRepository<Stock> _stockRepository;

        public StockController(IRepository<Stock> stockRepository)
        {
            _stockRepository = stockRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stocks = await _stockRepository.GetAllAsync();
            return Ok(stocks);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var stock = await _stockRepository.GetByIdAsync(id);
            if (stock == null) return NotFound();
            return Ok(stock);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Stock stock)
        {
            await _stockRepository.AddAsync(stock);
            return CreatedAtAction(nameof(GetById), new { id = stock.Id }, stock);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Stock stock)
        {
            if (id != stock.Id) return BadRequest();
            await _stockRepository.UpdateAsync(stock);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _stockRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
