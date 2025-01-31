using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudienceController : ControllerBase
    {
        private readonly IAudienceBll _audience;

        public AudienceController(IAudienceBll audience)
        {
            _audience = audience;
        }

        [HttpPost]
        public async Task< Audience> Add(Audience audience)
        {
            
            return await _audience.Add(audience);;
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Audience updatedAudience)
        {
            _audience.Update(id,updatedAudience);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _audience.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<Audience> GetById(int id)
        {
            //Audience audience =await _audience.GetById(id);
            //if (audience != null)
            //{
            //    return audience;
            //}
            //else
            //{
            //    return  NotFound();
            //}
            return await _audience.GetById(id);
        }
    }

}

