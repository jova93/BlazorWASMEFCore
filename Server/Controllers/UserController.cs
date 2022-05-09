using BlazorWASMEFCore.Server.Interfaces;
using BlazorWASMEFCore.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWASMEFCore.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUser _IUser;

    public UserController(IUser iUser)
    {
        _IUser = iUser;
    }

    [HttpGet]
    public async Task<List<User>> Get()
    {
        return await Task.FromResult(_IUser.GetUserDetails());
    }
}
