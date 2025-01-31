using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
       
        private readonly IGameBll _game;

        public GameController(IGameBll _game)
        {
            _game = _game;
        }

        [HttpPost]
        public async Task< Game> Add(Game game)
        {
            
            return await _game.Add(game);;
        }

        [HttpPut("{id}")]
        public async Task<Game> Update(Game updatedGame)
        {
            return await _game.Update(updatedGame);
            
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {         
            return await _game.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<Game> GetById(int id)
        {
            return await _game.GetById(id);
        }

        [HttpGet()]
        public async Task<List<Game>> GetAll()
        {
            return await _game.GetAll();
        }
    }

    }

