using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audience = DTO.Classes.Audience;

namespace BLL.Functions
{
    public class AudienceBll : IAudienceBll
    {
        readonly IAudienceDal dal;
        readonly IMapper mapper;

        public AudienceBll(IAudienceDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }


        public async Task<Audience> Add(Audience audience)
        {
            DAL.Models.Audience a= await dal.Add(mapper.Map<Audience,DAL.Models.Audience>(audience));
            return mapper.Map<DAL.Models.Audience, Audience>(a); 
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<Audience>> GetAll()
        {
            return  mapper.Map<List<DAL.Models.Audience>,List<Audience>>(await dal.GetAll());
        }

        public async Task<Audience> GetById(int id)
        {
            return mapper.Map<DAL.Models.Audience,Audience>(await dal.GetById(id));

        }

        public async Task<Audience> Update(int id, Audience audience)
        {
            throw new NotImplementedException();
            //DAL.Models.Audience a = mapper.Map<Audience, DAL.Models.Audience>(audience);
            //return mapper.Map<DAL.Models.Audience, Audience>(await dal.Update(id,a));
        }
    }
}
