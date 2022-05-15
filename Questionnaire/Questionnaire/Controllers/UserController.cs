using be.Data;
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

        #region CRUD for user

        [HttpGet("")]
        public ActionResult GetUsers()
        {
            return Ok(_userServices.GetUsers());
        }

        [HttpGet("{userId}")]
        public ActionResult GetUserById(long userId)
        {
            return Ok(_userServices.GetUserById(userId));
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            return Ok(_userServices.CreateUser(user));
        }

        [HttpPut]
        public ActionResult UpdateUser(User user)
        {
            return Ok(_userServices.UpdateUser(user));
        }

        [HttpDelete]
        public ActionResult DeleteUser(long userId)
        {
            return Ok(_userServices.DeleteUser(userId));
        }

        #endregion
    }
}