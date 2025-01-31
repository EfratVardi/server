using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeGameController : Controller
    {

        private readonly ITypeGameBll _TypeGame;

        public TypeGameController(ITypeGameBll TypeGame)
        {
            _TypeGame = TypeGame;
        }

        [HttpPost]
        public async Task<TypeGame> Add(TypeGame TypeGame)
        {

            return await _TypeGame.Add(TypeGame); ;
        }

        [HttpPut("{id}")]
        public async Task<TypeGame> Update(TypeGame updatedTypeGame)
        {
            return await _TypeGame.Update(updatedTypeGame);

        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _TypeGame.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<TypeGame> GetById(int id)
        {
            return await _TypeGame.GetById(id);
        }

        [HttpGet()]
        public async Task<List<TypeGame>> GetAll()
        {
            return await _TypeGame.GetAll();
        }
    }

}
