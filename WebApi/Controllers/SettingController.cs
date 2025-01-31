using BLL.Interfaces;
using DTO.Classes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : Controller
    {
        
            private readonly ISettingsBll _Settings;

            public SettingController(ISettingsBll Settings)
            {
                _Settings = Settings;
            }

            [HttpPost]
            public async Task<Settings> Add(Settings Setting)
            {

                return await _Settings.Add(Setting); ;
            }

            [HttpPut("{id}")]
            public async Task<Settings> Update(int id,Settings updatedSetting)
            {
                return await _Settings.Update(id,updatedSetting);

            }

            [HttpDelete("{id}")]
            public async Task<bool> Delete(int id)
            {
                return await _Settings.Delete(id);
            }

            [HttpGet("{id}")]
            public async Task<Settings> GetByGameId(int id)
            {
                return await _Settings.GetByGameId(id);
            }

          
        }

    }

