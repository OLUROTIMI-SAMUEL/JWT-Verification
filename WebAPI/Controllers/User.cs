using Application.Contract;
using Application.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User : ControllerBase
    {
        private readonly IUser user;

        public User(IUser user)
        {
            this.user = user;
        }

        [HttpPost("login")]

        public async Task<ActionResult<LoginResponse>> LogUserIn(LoginDTO loginDTO)
        {
            var result = await user.LoginUserAsync(loginDTO);
            return Ok(result);
        }



        [HttpPost("register")]

        public async Task<ActionResult<LoginResponse>> RegisterUser(RegisterUserDTO registerDTO)
        {
            var result = await user.RegisterUserAsync(registerDTO);
            return Ok(result);
        }
    }
}
