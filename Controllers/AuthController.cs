using JwtAuthDemo.Models;
using JwtAuthDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            var token = _authService.Authenticate(login);

            if (token == null)
                return Unauthorized("Invalid credentials");

            return Ok(new { Token = token });
        }
    }
}
