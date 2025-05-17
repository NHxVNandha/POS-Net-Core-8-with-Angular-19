using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Transactions;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Transactions
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IRepository<Payment> _paymentRepository;

        public PaymentsController(IRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var payments = await _paymentRepository.GetAllAsync();
            return Ok(payments);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var payment = await _paymentRepository.GetByIdAsync(id);
            if (payment == null) return NotFound();
            return Ok(payment);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Payment payment)
        {
            await _paymentRepository.AddAsync(payment);
            return CreatedAtAction(nameof(GetById), new { id = payment.Id }, payment);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Payment payment)
        {
            if (id != payment.Id) return BadRequest();
            await _paymentRepository.UpdateAsync(payment);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _paymentRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
