using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces;

public interface IHowKnownDal
{
    Task<List<HowKnown>> GetAll();

    Task<HowKnown> Add(HowKnown howKnown);

    Task<HowKnown> Update(HowKnown howKnown);

    Task<bool> Delete(int id);

    Task<HowKnown> GetById(int id);
}
