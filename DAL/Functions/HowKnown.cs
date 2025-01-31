using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Functions;

public partial class HowKnownDal : IHowKnownDal
{
    CountdContext db;
    public HowKnownDal(CountdContext db)
    {
        this.db = db;
    }

    public async Task<HowKnown> Add(HowKnown howKnown)
    {
        try
        {
           await db.HowKnowns.AddAsync(howKnown);
           await db.SaveChangesAsync();
            return howKnown;
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

    public async Task<List<HowKnown>> GetAll()
    {
        try
        {
            return await db.HowKnowns.ToListAsync();
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

    public Task<HowKnown> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<HowKnown> Update(HowKnown howKnown)
    {
        throw new NotImplementedException();
    }
    /////////////
    ///
    

    
}


