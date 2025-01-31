using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface IUserDal
{
    Task<User> SignIn(User user);

    Task<User> Login(string email, string password);

    Task<List<User>> GetAll();
    Task<User> Update(User gender);

    Task<bool> Delete(int id);

    Task<User> GetById(int id);
}
