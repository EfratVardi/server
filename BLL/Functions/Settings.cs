using AutoMapper;
using BLL.Interfaces;
using DAL.Functions;
using DAL.Interfaces;
using DAL.Models;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Functions
{
    public class SettingsBll : ISettingsBll
    {
        ISettingDal dal;
        IMapper mapper;

        public SettingsBll(ISettingDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<Settings> Add(Settings settings)
        {
            DAL.Models.Setting x = await dal.Add(mapper.Map<Settings, DAL.Models.Setting>(settings));
            return mapper.Map<DAL.Models.Setting, Settings>(x);
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<Settings> GetByGameId(int gameId)
        {
            return mapper.Map<DAL.Models.Setting, Settings>(await dal.GetByGameId(gameId));
        }

        public async Task<Settings> Update(int gameId, Settings settings)
        {
            DAL.Models.Setting x = await dal.Update(gameId,mapper.Map<Settings, DAL.Models.Setting>(settings));
            return mapper.Map<DAL.Models.Setting, Settings>(x);
        }
    }
}
