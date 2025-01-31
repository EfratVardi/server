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
using TypeGame = DTO.Classes.TypeGame;

namespace BLL.Functions
{
    public class TypeGameBll : ITypeGameBll
    {
        ITypeGameDal dal;
        IMapper mapper;

        public TypeGameBll(ITypeGameDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<TypeGame> Add(TypeGame typeGame)
        {
            DAL.Models.TypeGame x = await dal.Add(mapper.Map<TypeGame, DAL.Models.TypeGame>(typeGame));
            return mapper.Map<DAL.Models.TypeGame, TypeGame>(x);
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<TypeGame>> GetAll()
        {
            return mapper.Map<List<DAL.Models.TypeGame>, List<TypeGame>>(await dal.GetAll());
        }

        public async Task<TypeGame> GetById(int id)
        {
            return mapper.Map<DAL.Models.TypeGame, TypeGame> (await dal.GetById(id));
        }

        public async Task<TypeGame> Update(TypeGame typeGame)
        {
            DAL.Models.TypeGame x = await dal.Update(mapper.Map<TypeGame, DAL.Models.TypeGame>(typeGame));
            return mapper.Map<DAL.Models.TypeGame, TypeGame>(x);
        }
    }
}
