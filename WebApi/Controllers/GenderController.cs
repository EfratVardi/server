using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : Controller
    {

        private readonly IGenderBll _gender;

        public GenderController(IGenderBll gender)
        {
            _gender = gender;
        }

        [HttpPost]
        public async Task<Gender> Add(Gender Gender)
        {

            return await _gender.Add(Gender); ;
        }

        [HttpPut("{id}")]
        public async Task<Gender> Update(Gender updatedGender)
        {
            return await _gender.Update(updatedGender);

        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _gender.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<Gender> GetById(int id)
        {
            return await _gender.GetById(id);
        }

        [HttpGet()]
        public async Task<List<Gender>> GetAll()
        {
            return await _gender.GetAll();
        }
    }

}

