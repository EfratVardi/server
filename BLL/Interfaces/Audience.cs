using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAudienceBll
    {
        Task<List<Audience>> GetAll();

        Task<Audience> Add(Audience audience);

        Task<Audience> Update(int id, Audience audience);

        Task<bool> Delete(int id);

        Task<Audience> GetById(int id);

    }
}
