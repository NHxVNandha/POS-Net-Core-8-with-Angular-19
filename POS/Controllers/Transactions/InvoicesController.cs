using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.Transactions;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.Transactions
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoicesController(IRepository<Invoice> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var invoices = await _invoiceRepository.GetAllAsync();
            return Ok(invoices);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var invoice = await _invoiceRepository.GetByIdAsync(id);
            if (invoice == null) return NotFound();
            return Ok(invoice);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Invoice invoice)
        {
            await _invoiceRepository.AddAsync(invoice);
            return CreatedAtAction(nameof(GetById), new { id = invoice.Id }, invoice);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Invoice invoice)
        {
            if (id != invoice.Id) return BadRequest();
            await _invoiceRepository.UpdateAsync(invoice);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _invoiceRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
