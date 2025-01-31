using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HowKnownController : Controller
    {

        private readonly IHowKnownBll _HowKnown;

        public HowKnownController(IHowKnownBll HowKnown)
        {
            _HowKnown = HowKnown;
        }

        [HttpPost]
        public async Task<HowKnown> Add(HowKnown HowKnown)
        {

            return await _HowKnown.Add(HowKnown); ;
        }

        [HttpPut("{id}")]
        public async Task<HowKnown> Update(HowKnown updatedHowKnown)
        {
            return await _HowKnown.Update(updatedHowKnown);

        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _HowKnown.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<HowKnown> GetById(int id)
        {
            return await _HowKnown.GetById(id);
        }

        [HttpGet()]
        public async Task<List<HowKnown>> GetAll()
        {
            return await _HowKnown.GetAll();
        }
    }

}
