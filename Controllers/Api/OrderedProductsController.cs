using LetsShopping.Data;
using LetsShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetsShopping.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderedProductsController : ControllerBase
    {

        private readonly LetsShoppingContext _context;

        public OrderedProductsController(LetsShoppingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<OrderedProducts>> GetAll()
        {
            return await _context.OrderedProducts.ToListAsync();
        }

    }
}
