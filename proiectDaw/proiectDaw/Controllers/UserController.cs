using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiectDaw.Helper.Attributes;
using proiectDaw.Migrations;
using proiectDaw.Models.DTOs;
using proiectDaw.Models;
using proiectDaw.Services.UserService;
using proiectDaw.Helper;

namespace proiectDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //Create
        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser(UserRequestDTO user)
        {
            var createUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age,
                Role = Roles.User,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password)
            };

            await _userService.Create(createUser);
            return Ok();
        }

        [HttpPost("createAdmin")]
        public async Task<IActionResult> CreateAdmin(UserRequestDTO user)
        {
            var createUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Age = user.Age,
                Role = Roles.Admin,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password)
            };

            await _userService.Create(createUser);
            return Ok();
        }

        [HttpPost("authentificate")]
        public async Task<IActionResult> Authentificate(UserRequestDTO user)
        {
            var response = _userService.Authentificate(user);
            if (response == null)
            {
                return BadRequest("Invalid");
            }
            return Ok();
        }

        //Get
        [HttpGet("getAll")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        //Update
        [HttpPut("update/{id}")]
        [Authorization(Roles.Admin, Roles.User)]
        public IActionResult UpdateUser(Guid id, [FromBody] UserRequestDTO user)
        {
            var updateUser = _userService.GetById(id);
            if (updateUser == null)
            {
                return BadRequest("Id not found");
            }
            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.Email = user.Email;
            updateUser.Age = user.Age;
            _userService.Save();
            return Ok();
        }

        //Delete
        [HttpDelete("delete/{id}")]
        [Authorization(Roles.Admin)]
        public IActionResult DeleteUser(Guid id)
        {
            var deleteUser = _userService.GetById(id);
            if (deleteUser == null)
            {
                return BadRequest("Id not found");
            }
            _userService.Delete(deleteUser);
            _userService.Save();
            return Ok();
        }
    }
}
