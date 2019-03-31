using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Api.Interface
{
    public interface IUserService
    {
        User GetUser(string id);

        User InsertUser(User user);

        User Update(User user);

        List<User> GetAll();

        bool DeleteUser(string id);

    }
}
