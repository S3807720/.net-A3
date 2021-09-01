﻿using LetsShopping.Data;
using LetsShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        [HttpGet]
        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

    }
}
