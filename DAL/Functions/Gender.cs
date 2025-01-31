using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Functions;

public partial class GenderDal : IGenderDal
{
    CountdContext db;
    public GenderDal(CountdContext db)
    {
        this.db = db;
    }

    public async Task<Gender> Add(Gender gender)
    {
        try
        {
            await db.Genders.AddAsync(gender);
            await db.SaveChangesAsync();
            return  gender;
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

    public async Task<List<Gender>> GetAll()
    {
        try
        {
            return await db.Genders.ToListAsync();
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

    public Task<Gender> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Gender> Update(Gender gender)
    {
        throw new NotImplementedException();
    }
   
    
}
