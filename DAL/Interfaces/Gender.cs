using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface IGenderDal
{
    Task<List<Gender>> GetAll();

    Task<Gender> Add(Gender gender);

    Task<Gender> Update(Gender gender);

    Task<bool> Delete(int id);

    Task<Gender> GetById(int id);
}
