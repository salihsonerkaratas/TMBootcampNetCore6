using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BootcampProje.Controllers
{
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EfAdminRepository());
        public IActionResult Index()
        {
            var values = am.GetListAll();
            return View(values);

        }
    }
}
