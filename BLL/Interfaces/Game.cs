using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGameBll
    {
        Task< List<Game>> GetAll();

        Task<Game> Add(Game games);

        Task<Game> Update(Game games);

        Task<bool> Delete(int id);

        Task<Game> GetById(int id);
        
        Task<List<Game>> GetByUserId(int userId);
    }
}
