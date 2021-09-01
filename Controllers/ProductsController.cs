using LetsShopping.Data;
using LetsShopping.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LetsShopping.Controllers
{
    public class ProductsController : Controller
    {
        private readonly LetsShoppingContext _context;

        public ProductsController(LetsShoppingContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}
