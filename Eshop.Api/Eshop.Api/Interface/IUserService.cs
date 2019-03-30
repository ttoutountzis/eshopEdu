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

        bool DeleteUser(string id);

    }
}
