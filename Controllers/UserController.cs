using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineFoodDeliveryBackend.Models;

namespace OnlineFoodDeliveryBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {

            if (ModelState.IsValid)
            {

                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public IActionResult Login(Login loginModel)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == loginModel.Username && u.Password == loginModel.Password);
            if (user != null)
            {
                // Return the username upon successful authentication
                return Ok(new { Username = user.Username });
            }
            return BadRequest("Invalid username or password");
        }
    }


}
