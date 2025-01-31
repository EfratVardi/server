using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserBll
    {
        Task<User> SignIn(User user);
        
        Task<User> Login(string email, string password);
        
        Task<List<User>> GetAll();

        Task<User> Update(User gender);

        Task<bool> Delete(int id);

        Task<User> GetById(int id);
    }
}
