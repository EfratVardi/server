using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Functions;

public partial class GameDal : IGameDal
{
    CountdContext db;
    public GameDal(CountdContext db)
    {
        this.db = db;
    }

    public async Task<Game> Add(Game game)
    {
        try
        {
            await db.Games.AddAsync(game);
            await db.SaveChangesAsync();
            return game;
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
            var gameToDelete = await db.Games.FirstOrDefaultAsync(g => g.Id == id);

            if (gameToDelete != null)
            {
                //מחיקה מהגדרות
              //bool a= await SettingDal.Delete(gameToDelete.SettingsId);
                db.Games.Remove(gameToDelete);
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

    public async Task<List<Game>> GetAll()
    {

        try
        {
            return await db.Games.ToListAsync();
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

    public async Task<Game> GetById(int id)
    {
        try
        {
            return await db.Games.FirstOrDefaultAsync(g => g.Id == id);
        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }

    public async Task<List<Game>> GetByUserId(int userId)
    {
        try
        {
            return await db.Games.Where(g => g.DetailsId == userId).ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }

    public async Task<Game> Update(Game game)
    {
        try
        {
            Game gameToUpdate = await GetById(game.Id);
            if (gameToUpdate != null)
            {
                gameToUpdate.Name = game.Name;
                db.Games.Update(gameToUpdate);
                await db.SaveChangesAsync();
                return gameToUpdate;
            }
            else throw new Exception("game not found");

        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }
}
