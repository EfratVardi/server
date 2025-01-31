using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {


        private readonly IUserBll _Users;

        public UserController(IUserBll Users)
        {
            _Users = Users;
        }

        [HttpPost]
        public async Task<User> SignIn(User User)
        {

            return await _Users.SignIn(User); ;
        }

        [HttpPut("{id}")]
        public async Task<User> Update(User updatedUser)
        {
            return await _Users.Update(updatedUser);

        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _Users.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<User> Login(string email, string password)
        {
            return await _Users.Login(email, password);
        }

        [HttpGet()]
        public async Task<List<User>> GetAll()
        {
            return await _Users.GetAll();
        }
    }

}

