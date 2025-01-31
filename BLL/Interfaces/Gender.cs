using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGenderBll
    {
        Task< List<Gender>> GetAll();

        Task<Gender> Add(Gender gender);

        Task<Gender> Update(Gender gender);

        Task<bool> Delete(int id);

        Task<Gender> GetById(int id); 
    }
}
