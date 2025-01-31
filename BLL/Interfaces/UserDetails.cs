using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserDetailsBll
    {
        Task<List<UserDetails>> GetAll();

        Task<UserDetails> Add(UserDetails userDetails);

        Task<UserDetails> Update(int userId,UserDetails userDetails);

        Task<bool> Delete(int id);

        Task<UserDetails> GetByuserId(int userId);
    }
}
