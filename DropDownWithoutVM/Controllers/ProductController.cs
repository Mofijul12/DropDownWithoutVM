using DropDownWithoutVM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDownWithoutVM.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Product/Index
        public IActionResult Index()
        {
            // Fetch all categories from the database
            var categories = _context.Categories.ToList();

            // Create a ViewModel and populate the Categories list
            var viewModel = new ProductCategoryViewModel
            {
                Categories = categories.Select(c => new SelectListItem
                {
                    Text = c.Name,        // The name of the category to display
                    Value = c.CategoryId.ToString() // The value to submit (CategoryId)
                }).ToList()
            };

            return View(viewModel);
        }

    }

}
