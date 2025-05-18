using Microsoft.AspNetCore.Mvc;
using POS.Domain.Entities.ConfigurationAndOthers;
using POS.Infrastructure.Repositories.Interfaces;

namespace POS.Controllers.ConfigurationAndOthers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IRepository<Setting> _settingRepository;
        private readonly IRepository<Discount> _discountRepository;
        private readonly IRepository<Promotion> _promotionRepository;

        public ConfigurationController(
            IRepository<Setting> settingRepository,
            IRepository<Discount> discountRepository,
            IRepository<Promotion> promotionRepository)
        {
            _settingRepository = settingRepository;
            _discountRepository = discountRepository;
            _promotionRepository = promotionRepository;
        }

        // ==== Setting ====
        [HttpGet("settings")]
        public async Task<IActionResult> GetSettings()
        {
            var settings = await _settingRepository.GetAllAsync();
            return Ok(settings);
        }

        [HttpPost("settings")]
        public async Task<IActionResult> CreateSetting(Setting setting)
        {
            await _settingRepository.AddAsync(setting);
            return CreatedAtAction(nameof(GetSettings), new { id = setting.Id }, setting);
        }

        // ==== Discount ====
        [HttpGet("discounts")]
        public async Task<IActionResult> GetDiscounts()
        {
            var discounts = await _discountRepository.GetAllAsync();
            return Ok(discounts);
        }

        [HttpPost("discounts")]
        public async Task<IActionResult> CreateDiscount(Discount discount)
        {
            await _discountRepository.AddAsync(discount);
            return CreatedAtAction(nameof(GetDiscounts), new { id = discount.Id }, discount);
        }

        // ==== Promotion ====
        [HttpGet("promotions")]
        public async Task<IActionResult> GetPromotions()
        {
            var promotions = await _promotionRepository.GetAllAsync();
            return Ok(promotions);
        }

        [HttpPost("promotions")]
        public async Task<IActionResult> CreatePromotion(Promotion promotion)
        {
            await _promotionRepository.AddAsync(promotion);
            return CreatedAtAction(nameof(GetPromotions), new { id = promotion.Id }, promotion);
        }
    }
}
