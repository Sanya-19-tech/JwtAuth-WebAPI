using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/secure")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet("user")]
        public IActionResult UserEndpoint()
        {
            return Ok("Hello Authenticated User!");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin")]
        public IActionResult AdminEndpoint()
        {
            return Ok("Hello Admin!");
        }
    }
}
