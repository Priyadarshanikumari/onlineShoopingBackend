using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineFoodDeliveryBackend.Models;

namespace OnlineFoodDeliveryBackend.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment(Payment payment)
        {
            if (ModelState.IsValid)
            {
                // Save payment data to the database
                payment.PaymentDate = DateTime.Now; // Set payment date
                _context.Payments.Add(payment);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
