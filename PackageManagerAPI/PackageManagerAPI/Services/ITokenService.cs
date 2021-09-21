using PackageManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Services
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, User user);
        bool IsTokenValid(string key, string issuer, string token);
    }
}
