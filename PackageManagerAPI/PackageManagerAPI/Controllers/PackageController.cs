using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PackageManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PackageManagerAPI.DTOModels;

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

        /// <summary>
        /// 
        /// </summary>
        /// 
        [HttpGet]
        [Produces("application/json")]
        public List<OrderDTO> GetOrders()
        {
            int userId = -1;

            Int32.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out userId);

            List<OrderDTO> orders = _dbContext.Orders
                .Where(o => o.User.UserId == userId)
                .Select(p => new OrderDTO()
                 {
                    OrderId = p.OrderId,
                    PackageId = p.PackageId,
                    Status = p.Status,
                    StatusShortHand = p.StatusShortHand,
                    Description = p.Description,
                    ItemCount = p.Products.Count
                })
                .ToList();

            return orders;
        }

        [HttpGet("find/{PackageId}")]
        [Produces("application/json")]
        public List<OrderDTO> FindOrdersByPackageId(string PackageId)


        {
            int userId = -1;

            Int32.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out userId);

            List<OrderDTO> orders = _dbContext.Orders
                .Where(o => o.User.UserId == userId)
                .Where(o => EF.Functions.Like(o.PackageId, PackageId+"%"))
                .Select(p => new OrderDTO()
                {
                    OrderId = p.OrderId,
                    PackageId = p.PackageId,
                    Status = p.Status,
                    StatusShortHand = p.StatusShortHand,
                    Description = p.Description,
                    ItemCount = p.Products.Count
                })
                .ToList();

            return orders;
        }

        [HttpGet("{orderId}")]
        [Produces("application/json")]
        public OrderDetailDTO GetOrderById(int orderId)
        {
            int userId = -1;

            Int32.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out userId);

            OrderDetailDTO orderDetailDTO = _dbContext.Orders
                 .Include(o => o.Products)
                 .Where(o => o.User.UserId == userId)
                 .Where(o => o.OrderId == orderId)
                 .Select(o => new OrderDetailDTO
                 {
                     OrderId = o.OrderId,
                     PackageId = o.PackageId,
                     Status = o.Status,
                     StatusShortHand = o.StatusShortHand,
                     Description = o.Description,
                     Products = o.Products.Select(p => new ProductDTO
                     {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        ProductPrice = p.ProductPrice
                     }).ToList()
                 }).FirstOrDefault();
                 
            return orderDetailDTO;
        }


    }
}
