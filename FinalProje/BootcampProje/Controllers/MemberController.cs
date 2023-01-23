using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BootcampProje.Controllers
{
    public class MemberController : Controller
    {
        MemberManager mm = new MemberManager(new EfMemberRepository());
        public IActionResult Index()
        {
            var values = mm.GetListAll();
            return View(values);

        }
    }
}
