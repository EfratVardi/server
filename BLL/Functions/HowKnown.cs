using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Functions
{
    public class HowKnownBll : IHowKnownBll
    {
        IHowKnownDal dal;
        IMapper mapper;

        public HowKnownBll(IHowKnownDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<HowKnown> Add(HowKnown howKnown)
        {
            DAL.Models.HowKnown x = await dal.Add(mapper.Map<HowKnown, DAL.Models.HowKnown>(howKnown));
            return mapper.Map<DAL.Models.HowKnown, HowKnown>(x);
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<HowKnown>> GetAll()
        {
            return mapper.Map<List<DAL.Models.HowKnown>, List<HowKnown>>(await dal.GetAll());
        }

        public Task<HowKnown> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<HowKnown> Update(HowKnown howKnown)
        {
            throw new NotImplementedException();
        }
    }
}
