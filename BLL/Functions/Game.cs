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
using Game = DTO.Classes.Game;

namespace BLL.Functions
{
    public class GameBll : IGameBll
    {
        IGameDal dal;
        IMapper mapper;

        public GameBll(IGameDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<Game> Add(Game games)
        {
            DAL.Models.Game x = await dal.Add(mapper.Map<Game, DAL.Models.Game>(games));
            return mapper.Map<DAL.Models.Game, Game>(x);
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<Game>> GetAll()
        {
            return mapper.Map<List<DAL.Models.Game>, List<Game>>(await dal.GetAll());
        }

        public async Task<Game> GetById(int id)
        {
            return mapper.Map<DAL.Models.Game, Game>(await dal.GetById(id));
        }

        public async Task<List<Game>> GetByUserId(int userId)
        {
            return mapper.Map< List<DAL.Models.Game>,List<Game>>(await dal.GetByUserId(userId));
        }

        public async Task<Game> Update(Game games)
        {
            DAL.Models.Game x = await dal.Update(mapper.Map<Game, DAL.Models.Game>(games));
            return mapper.Map<DAL.Models.Game, Game>(x);

        }
    }
}
