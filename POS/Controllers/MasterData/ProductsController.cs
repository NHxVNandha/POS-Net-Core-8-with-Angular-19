using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.MasterData;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.MasterData
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _productRepository.AddAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Product product)
        {
            if (id != product.Id)
                return BadRequest();

            await _productRepository.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _productRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
