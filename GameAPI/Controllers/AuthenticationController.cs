using GameAPI.Entities;
using GameAPI.Models;
using GameAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController(IAuthService authservice) : ControllerBase
    {

        public static User user = new();

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDTO request)
        {
            var user = await authservice.RegisterAsync(request);
            if (user == null)
            {
                return BadRequest("Username already taken.");
            }

            return Ok(user);
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {
            var token = await authservice.LoginAsync(request);
            if (token == null)
            {
                return BadRequest("Invalid username or password.");
            }

            return Ok(token);
        }

    }
}
