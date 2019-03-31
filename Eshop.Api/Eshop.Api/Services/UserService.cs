using Eshop.Api.Context;
using Eshop.Api.Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Api.Services
{
    public class UserService : IUserService
    {
        private MsDbContext _ctx;

        public UserService(MsDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool DeleteUser(string id)
        {
            User user = _ctx.Users.Find(id);
            if (user == null)
            {
                return false;
            }
            _ctx.Users.Remove(user);
            _ctx.SaveChanges();
            return true;
        }

        public User GetUser(string id)
        {

            return new User();
        }

       
        public User InsertUser(User user)
        {
            user.IsActive = true;
            user.LastUpdate = DateTime.UtcNow;
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
            return user;
        }

        
    }
}
