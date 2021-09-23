using PackageManagerAPI.Helpers;
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

        public User GetUser(User user, out bool Verified)
        {
            Verified = false;
            var resultUSer = _dbContext.Users
                                   .Where(s => s.UserName == user.UserName)
                                   .FirstOrDefault();

            if(resultUSer == null) return new User();

            bool PasswordVerified = BCrypt.Net.BCrypt.Verify(user.Password, resultUSer.Password);
            if(PasswordVerified)
            {
                Verified = true;
                return resultUSer;
            }
            else
            {
                throw new ArgumentNullException("Incorrect username or password!");
            }
            
        }
    }
}
