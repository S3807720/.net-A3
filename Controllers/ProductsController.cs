using LetsShopping.Data;
using LetsShopping.Models;
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

        public IActionResult AddProduct()
        {
            return View(new Product());
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (product.Price <= 0)
            {
                ModelState.AddModelError(nameof(product.Price), "Amount must be a positive number.");
            }
            if (!ModelState.IsValid)
            {
                return View(product);        
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
