using PackageManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Services
{
    public  interface IUserRepository
    {
        User GetUser(User user);
    }
}
