using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISettingsBll
    {
        //List<Settings> GetAll();

        Task<Settings> Add(Settings settings);

        Task<Settings> Update(int gameId,Settings settings);

        Task<bool> Delete(int id);

        Task<Settings> GetByGameId(int gameId);
    }
}
