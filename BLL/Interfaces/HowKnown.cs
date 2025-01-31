using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IHowKnownBll
    {
        Task<List<HowKnown>> GetAll();

        Task<HowKnown> Add(HowKnown howKnown);

        Task<HowKnown> Update(HowKnown howKnown);

        Task<bool> Delete(int id);

        Task<HowKnown> GetById(int id);
    }
}
