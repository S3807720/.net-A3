using LetsShopping.Data;
using LetsShopping.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LetsShopping.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly LetsShoppingContext _context;

        public OrderController(LetsShoppingContext context)
        {
            _context = context;
        }
        public Order Get(int id)
        {
            return _context.Orders.Find(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

    }
}
