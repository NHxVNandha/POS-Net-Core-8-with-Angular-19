using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.MasterData;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.MasterData
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomersController(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerRepository.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Customer customer)
        {
            if (id != customer.Id)
                return BadRequest();

            await _customerRepository.UpdateAsync(customer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _customerRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
