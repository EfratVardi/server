using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailController : Controller
    {
        private readonly IUserDetailsBll _UserDetails;

        public UserDetailController(IUserDetailsBll UserDetails)
        {
            _UserDetails = UserDetails;
        }

        [HttpPost]
        public async Task<UserDetails> Add(UserDetails UserDetails)
        {

            return await _UserDetails.Add(UserDetails); ;
        }

        [HttpPut("{id}")]
        public async Task<UserDetails> Update(int id, UserDetails updatedUserDetails)
        {
            return await _UserDetails.Update(id,updatedUserDetails);

        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _UserDetails.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<UserDetails> GetByuserId(int id)
        {
            return await _UserDetails.GetByuserId(id);
        }

        [HttpGet()]
        public async Task<List<UserDetails>> GetAll()
        {
            return await _UserDetails.GetAll();
        }
    }

}
