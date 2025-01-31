using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Functions;

public partial class TypeGameDal : ITypeGameDal
{
    CountdContext db;
    public TypeGameDal(CountdContext db)
    {
        this.db = db;
    }

    public async Task<TypeGame> Add(TypeGame typeGame)
    {
        try
        {
            await db.TypeGames.AddAsync(typeGame);
            await db.SaveChangesAsync();
            return typeGame;
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

    public async Task<bool> Delete(int id)
    {
        try
        {
            var TypeGameToDelete = await db.TypeGames.FirstOrDefaultAsync(g => g.Id == id);

            if (TypeGameToDelete != null)
            { db.TypeGames.Remove(TypeGameToDelete);
                await db.SaveChangesAsync();
                return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }

    public async Task<List<TypeGame>> GetAll()
    {
        try
        {
            return await db.TypeGames.ToListAsync();
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

    public async Task<TypeGame> GetById(int id)
    {
        return await db.TypeGames.FirstOrDefaultAsync(g => g.Id == id);
    }

    public async Task<TypeGame> Update(TypeGame typeGame)
    {
        try
        {
            TypeGame typeGameToUpdate = await GetById(typeGame.Id);
            if (typeGameToUpdate != null)
            {
                typeGameToUpdate.Name=typeGame.Name;
                typeGameToUpdate.Description=typeGame.Description;
                typeGameToUpdate.Picture=typeGame.Picture;
                typeGameToUpdate.Price=typeGame.Price;
                db.TypeGames.Update(typeGameToUpdate);
                await db.SaveChangesAsync();
                return typeGameToUpdate;
            }
            else throw new Exception("game not found");

        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }

   
   
}
