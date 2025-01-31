using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.Functions;

public partial class UserDetailDal : IUserDetailDal
{
    CountdContext db;
    public UserDetailDal(CountdContext db)
    {
        this.db = db;
    }

    public async Task<UserDetail> Add(UserDetail userDetails)
    {
        try
        {
            await db.UserDetails.AddAsync(userDetails);
            await db.SaveChangesAsync();
            return userDetails;
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

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserDetail>> GetAll()
    {
        try
        {
            return await db.UserDetails.ToListAsync();
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

    public async Task<UserDetail> GetByuserId(int userId)
    {
        try
        {
            return await db.UserDetails.FirstOrDefaultAsync(ud => ud.Id == userId);
        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }

    public async Task<UserDetail> Update(int userId, UserDetail userDetails)
    {
        try
        {
            UserDetail detailsToUpdate = await GetByuserId(userId);
            if (detailsToUpdate != null)
            {
                detailsToUpdate.PhoneNumber = userDetails.PhoneNumber;
                detailsToUpdate.LastName = userDetails.LastName;
                detailsToUpdate.FirstName = userDetails.FirstName;
                detailsToUpdate.Gender = userDetails.Gender;
                detailsToUpdate.City = userDetails.City;
                db.UserDetails.Update(detailsToUpdate);
                await db.SaveChangesAsync();
                return detailsToUpdate;
            }
            else throw new Exception("game not found");

        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }




}
