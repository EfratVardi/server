using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface IAudienceDal
{
     Task<List<Audience>> GetAll();

     Task<Audience> Add(Audience audience);

    Task<Audience> Update(Audience audience);

    Task<bool> Delete(int id);

    Task<Audience> GetById(int id);

}
