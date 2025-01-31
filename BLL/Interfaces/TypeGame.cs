using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITypeGameBll
    {
        Task<List<TypeGame>> GetAll();

        Task<TypeGame> Add(TypeGame typeGame);

        Task<TypeGame> Update(TypeGame typeGame);

        Task<bool> Delete(int id);

        Task<TypeGame> GetById(int id);
    }
}
