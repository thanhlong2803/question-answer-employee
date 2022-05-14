using be.Services;
using Microsoft.AspNetCore.Mvc;

namespace Questionnaire.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userServices;
        public UserController(IUserService userServices)
        {
            _userServices = userServices;
        }
    }
}