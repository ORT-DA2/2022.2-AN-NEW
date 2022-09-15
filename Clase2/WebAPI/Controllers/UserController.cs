using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/Users")]
public class UserController : ControllerBase
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }


    [HttpPost]
    public IActionResult Add([FromBody] User user)
    {
        _userService.AddUser(user);
        return Created("", user);
    }
}