using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/Login")]
public class LoginController: ControllerBase
{
    private readonly IUserService _userService;

    public LoginController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost]
    public IActionResult Login(LoginDto loginDto)
    {
        loginDto.Token = _userService.Login(loginDto.Email, loginDto.Password);
        return Ok(loginDto);
    }
}