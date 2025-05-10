using Microsoft.AspNetCore.Mvc;

namespace DropDownWithoutVM.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
            
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
         public IActionResult Create(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
