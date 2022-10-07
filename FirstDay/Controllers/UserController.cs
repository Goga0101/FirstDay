using FirstDay.Interfaces;
using FirstDay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstDay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }




        [HttpPost("createPerson")]
        public CreateUserResponse CreateUser(UserModel request) => _userRepository.CreateUser(request);




        [HttpGet("getPerson")]
        public GetUserResponse GetUser(GetUserRequest request) => _userRepository.GetUser(request);
    }
}
