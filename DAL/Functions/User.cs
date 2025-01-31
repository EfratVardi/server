using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Functions;

public partial class UserDal : IUserDal
{
    CountdContext db;
    public UserDal(CountdContext db)
    {
        this.db = db;
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<User>> GetAll()
    {
        try
        {
            return await db.Users.ToListAsync();
        }
        catch (DbUpdateException ex)
        {
            throw new ApplicationException("An error occurred while saving data to the database. Please try again later.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("error-", ex);
        }
    }

    public Task<User> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> Login(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<User> SignIn(User user)
    {
        //Recipe newRecipe = db.Recipes.FirstOrDefault(r => r.Name == recipe.Name && r.UserId == recipe.UserId && r.CategoryId == recipe.CategoryId && r.LevelId == recipe.LevelId);
        //if (newRecipe != null)
        //{
        //    return newRecipe.Id;
        //}
        //else
        //{
        //    return -1;
        //}
        throw new NotImplementedException();
    }

    public Task<User> Update(User gender)
    {
        throw new NotImplementedException();
    }

    //public User Add(User user)
    //{
    //    try
    //    {
    //        var a = db.Users.Add(user);
    //        db.SaveChanges();
    //        return user;
    //    }
    //    catch
    //    {
    //        return null;
    //    }
    //}



   



}
