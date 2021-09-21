using PackageManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly PackageManagerContext _dbContext;

        public UserRepository(PackageManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User GetUser(User user)
        {
            User resultUSer = new User();
     
                bool PAsswordVerified = BCrypt.Net.BCrypt.Verify(user.Password, _dbContext.Users
                                   .Where(s => s.UserName == user.UserName)
                                   .FirstOrDefault<User>().Password);
                
                if(PAsswordVerified)
                {
                resultUSer = _dbContext.Users
                                   .Where(s => s.UserName == user.UserName)
                                   .FirstOrDefault<User>();
                }

            
            return resultUSer;
        }
    }
}
