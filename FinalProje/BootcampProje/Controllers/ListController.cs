using Microsoft.AspNetCore.Mvc;

namespace BootcampProje.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
