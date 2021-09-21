using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PackageManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PackageManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    [Authorize]
    public class PackageController : ControllerBase
    {
        private readonly PackageManagerContext _dbContext;

        public PackageController(PackageManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("all")]
        [HttpGet]
        [Produces("application/json")]
        public List<Order> GetOrders()
        {
            //doSomething()
            return new List<Order>();
        }

        [HttpGet]
        [Route("all/{orderId}")]
        [Produces("application/json")]
        public Order GetOrderById(int orderId)
        {
            //doSomething()
            return new Order();
        }


    }
}
