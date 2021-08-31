using LetsShopping.Data;
using LetsShopping.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LetsShopping.Controllers
{
    public class ProductsController : Controller
    {
        private readonly LetsShoppingContext _context;

        public ProductsController(LetsShoppingContext context) => _context = context;
        public async Task<IActionResult> Index()
        {
            var view = new ProductViewModel();
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
