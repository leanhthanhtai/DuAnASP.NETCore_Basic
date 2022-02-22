using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Application.System.Users;
using ProjectCore.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> PostAuthenticate([FromBody] LoginRequest request) {
            if (!ModelState.IsValid) {
                return BadRequest(request);
            }
            var result = await _userService.Authencate(request);
            if (result.IsSuccessed)
            {
                return Ok(result.ResultObj);
            }
            return BadRequest("Not Success Full!");
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> PostRegister([FromBody] RegisterRequest request) {

            if (!ModelState.IsValid)
            {
                return BadRequest(request);
            }
            var result = await _userService.Register(request);
            if (result.IsSuccessed)
            {
                return Ok("Register Success");
            }
            return BadRequest("Not Success Full!");
        }
    }
}
