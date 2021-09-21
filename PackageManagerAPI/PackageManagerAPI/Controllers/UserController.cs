using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PackageManagerAPI.DTOModels;
using PackageManagerAPI.Helpers;
using PackageManagerAPI.Models;
using PackageManagerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PackageManagerAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;

        public UserController(IConfiguration config, ITokenService tokenService, IUserRepository userRepository)
        {
            _config = config;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        [Route("login")]
        [AllowAnonymous]
        [HttpPost]
        [Produces("application/json")]
        public UserDTO Login(User user)
        {
            var validUser = _userRepository.GetUser(user);
            if (validUser != null)
            {
                generatedToken = _tokenService.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), validUser);
                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    return new UserDTO
                    {
                        Token = generatedToken,
                        UserName = user.UserName
                    };
                }
                else
                {
                    this.HttpContext.Response.StatusCode = 401;
                    throw new AppException($"The username or password is incorrect");
                }
            }
            else
            {
                this.HttpContext.Response.StatusCode = 401;
                throw new AppException($"The username or password is incorrect");
            }
        }

    }
}
