using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface IUserDetailDal
{
    Task<List<UserDetail>> GetAll();
   
    Task<UserDetail> Add(UserDetail userDetails);
   
    Task<UserDetail> Update(int userId, UserDetail userDetails);
   
    Task<bool> Delete(int id);

    Task<UserDetail> GetByuserId(int userId);
}
