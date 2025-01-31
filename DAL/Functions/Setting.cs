using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.Functions;

public partial class SettingDal : ISettingDal
{
    CountdContext db;
    public SettingDal(CountdContext db)
    {
        this.db = db;
    }

    public async Task<Setting> Add(Setting setting)
    {
        try
        {
            await db.Settings.AddAsync(setting);
            await db.SaveChangesAsync();
            return setting;
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
        //אולי הפונקציה תזומן ממחיקת משחק...
        try
        {
            var SettingToDelete = await db.Settings.FirstOrDefaultAsync(s => s.Id == id);

            if (SettingToDelete != null)
            {
                db.Settings.Remove(SettingToDelete);
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

    public async Task<Setting> GetByGameId(int gameId)
    {
        try
        {
            return await db.Settings.FirstOrDefaultAsync(g => g.Id == gameId);
        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }

    public async Task<Setting> Update(int gameId, Setting setting)
    {
        try
        {
            Setting settingToUpdate = await GetByGameId(gameId);
            if (settingToUpdate != null)
            {
                settingToUpdate.Color = setting.Color;
                settingToUpdate.Music= setting.Music;
                settingToUpdate.Background = setting.Background;
                db.Settings.Update(settingToUpdate);
                await db.SaveChangesAsync();
                return settingToUpdate;
            }
            else throw new Exception("game not found");

        }
        catch (Exception ex)
        {
            throw new Exception("Error-", ex);
        }
    }
   
}
