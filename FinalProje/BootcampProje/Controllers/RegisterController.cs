using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BootcampProje.Controllers
{
    public class RegisterController : Controller
    {
        MemberManager mm = new MemberManager(new EfMemberRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index (Member m)
        {
            MemberValidator validationRules = new MemberValidator();
            ValidationResult results = validationRules.Validate(m);
            if (results.IsValid)
            {
                m.MemberStatus = true;
                mm.MemberAdd(m);
                return View();
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}
