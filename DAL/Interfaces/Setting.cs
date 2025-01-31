using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface ISettingDal
{
    Task<Setting> Add(Setting settings);

    Task<Setting> Update(int gameId, Setting settings);

    Task<bool> Delete(int id);

    Task<Setting> GetByGameId(int gameId);
}
