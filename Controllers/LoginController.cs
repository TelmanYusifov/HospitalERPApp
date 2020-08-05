using HospitalERPNew.Data;
using HospitalERPNew.Filters;
using HospitalERPNew.Infrastructure;
using HospitalERPNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalERPNew.Controllers
{
    public class LoginController : Controller
    {
        private readonly HospitalDbContext _hospitalDbContext;
        
        public LoginController()
        {
            _hospitalDbContext = new HospitalDbContext();
        }
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            using (_hospitalDbContext)
            {
                bool isValid = _hospitalDbContext.AppUsers.Any(x => x.Email == loginModel.Email && x.Password == loginModel.Password);
                AppUser appUser = _hospitalDbContext.AppUsers.UserExists(loginModel);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(appUser.Email, false);
                    if(appUser.UserRole == UserType.Admin)
                        return RedirectToAction("AdminPage", "Login");
                    else if (appUser.UserRole == UserType.Reception)
                        return RedirectToAction("ReceptionPage", "Login");
                    else if (appUser.UserRole == UserType.Doctor)
                        return RedirectToAction("DoctorPage", "Login");
                }

                ModelState.AddModelError("", "Invalid username and password");
                return View();
            }
        }
        [Authorize(Roles ="Admin")]
        public ActionResult AdminPage()
        {
            return View();
        }
        [Authorize(Roles = "Reception")]
        public ActionResult ReceptionPage()
        {
            return View();
        }
        [Authorize(Roles = "Doctor")]
        public ActionResult DoctorPage()
        {
            return View();
        }
    }
}