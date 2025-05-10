using Microsoft.AspNetCore.Mvc;

namespace DropDownWithoutVM.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
