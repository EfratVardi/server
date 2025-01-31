using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Functions
{

    public partial class AudienceDal : IAudienceDal
    {
        CountdContext db;
        public AudienceDal(CountdContext db)
        {
            this.db = db;
        }

        public async Task<Audience> Add(Audience audience)
        {
            try
            {
                await db.Audiences.AddAsync(audience);
                await db.SaveChangesAsync();
                return audience;
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

        public async Task<List<Audience>> GetAll()
        {
            try
            {
                return await db.Audiences.ToListAsync();
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

        public Task<Audience> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Audience> Update(Audience audience)
        {
            throw new NotImplementedException();
        }
    }
}