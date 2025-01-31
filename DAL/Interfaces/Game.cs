using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface IGameDal
{
    Task<List<Game>> GetAll();

    Task<Game> Add(Game games);

    Task<Game> Update(Game games);

    Task<bool> Delete(int id);

    Task<Game> GetById(int id);

    Task<List<Game>> GetByUserId(int userId);
}
