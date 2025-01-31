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
    public class GenderBll : IGenderBll
    {
        IGenderDal dal;
        IMapper mapper;

        public GenderBll(IGenderDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<Gender> Add(Gender gender)
        {
            DAL.Models.Gender x = await dal.Add(mapper.Map<Gender, DAL.Models.Gender>(gender));
            return mapper.Map<DAL.Models.Gender, Gender>(x);
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<Gender>> GetAll()
        {
            return mapper.Map<List<DAL.Models.Gender>, List<Gender>>(await dal.GetAll());
        }

        public Task<Gender> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Gender> Update(Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
