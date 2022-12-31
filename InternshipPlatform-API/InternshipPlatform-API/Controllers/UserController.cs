using InternshipPlatform_API.Dto;
using InternshipPlatform_API.Dto.Request;
using InternshipPlatform_API.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternshipPlatform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            this._userService = userService;
        }
        [HttpPost("/auth/register")]
        public async Task<IActionResult> Post(RegisterDto registerData)
        {
            var response = await this._userService.Create(registerData);
            if (response.Success)
            {
                
                return Ok(response);
            }
            
            return BadRequest(response);
        }
        [HttpPost("/auth/login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            var success = await this._userService.Login(login);
            var response = new GlobalResponse<string>();
            if (success)
            {
                return Ok(response);
            }
            else
            {
                response.Success = false;
                response.Message = "Login not successfull.";
                return BadRequest(response);
            }
        }
    }
}
