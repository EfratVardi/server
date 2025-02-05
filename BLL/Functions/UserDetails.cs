using AutoMapper;
using BLL.Interfaces;
using DAL.Functions;
using DAL.Interfaces;
using DTO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Functions
{
    public class UserDetailsBll : IUserDetailsBll
    {
        readonly IUserDetailDal dal;
        readonly IMapper mapper;

        public UserDetailsBll(IUserDetailDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<UserDetails> Add(UserDetails userDetails)
        {
            DAL.Models.UserDetail x = await dal.Add(mapper.Map<UserDetails, DAL.Models.UserDetail>(userDetails));
            return mapper.Map<DAL.Models.UserDetail, UserDetails>(x);
        }

        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<UserDetails>> GetAll()
        {
            return mapper.Map<List<DAL.Models.UserDetail>, List<UserDetails>>(await dal.GetAll());
        }

        public async Task<UserDetails> GetByuserId(int userId)
        {
            return mapper.Map<DAL.Models.UserDetail, UserDetails> (await dal.GetByuserId(userId));
        }

        public async Task<UserDetails> Update(int userId, UserDetails userDetails)
        {
            DAL.Models.UserDetail x = await dal.Update(userId,mapper.Map<UserDetails, DAL.Models.UserDetail>(userDetails));
            return mapper.Map<DAL.Models.UserDetail, UserDetails>(x);
        }
    }
}
