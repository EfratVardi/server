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
using User = DTO.Classes.User;

namespace BLL.Functions
{
    public class UserBll : IUserBll
    {
        IUserDal dal;
        IMapper mapper;

        public UserBll(IUserDal dal)
        {
            this.dal = dal;

            var config = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile<CountDProfile>();
            });

            mapper = config.CreateMapper();
        }
        public async Task<bool> Delete(int id)
        {
            return await dal.Delete(id);
        }

        public async Task<List<User>> GetAll()
        {
            return mapper.Map<List<DAL.Models.User>, List<User>>(await dal.GetAll());
        }

        public async Task<User> GetById(int id)
        {
            return mapper.Map<DAL.Models.User, User>(await dal.GetById(id));
        }

        public async Task<User> Login(string email, string password)
        {
            return mapper.Map<DAL.Models.User, User>(await dal.Login(email, password));
        }

        public async Task<User> SignIn(User user)
        {
            DAL.Models.User x = await dal.SignIn(mapper.Map<User, DAL.Models.User>(user));
            return mapper.Map<DAL.Models.User, User>(x);
        }

        public async Task<User> Update(User user)
        {
            DAL.Models.User x = await dal.Update(mapper.Map<User, DAL.Models.User>(user));
            return mapper.Map<DAL.Models.User, User>(x);
        }
    }
}
