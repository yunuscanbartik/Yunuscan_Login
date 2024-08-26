using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.User;
using Service.Interfaces;

namespace Login.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService _service;
        public UserController(IService services) 
        {
            _service = services;    
        }
        [HttpPost(Name = "Getirici")]
        public IActionResult Login(UserLogin.Request request)
        {
            return Ok(_service.Login(request));
        }
    }
}
