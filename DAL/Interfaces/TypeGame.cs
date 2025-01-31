using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface ITypeGameDal
{
    Task<List<TypeGame>> GetAll();

    Task<TypeGame> Add(TypeGame typeGame);

    Task<TypeGame> Update(TypeGame typeGame);

    Task<bool> Delete(int id);

    Task<TypeGame> GetById(int id);
}
