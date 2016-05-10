using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Application.Models;
using BLL;
using Entities;

namespace Application.Controllers
{
    public class AccountController : Controller
    {
       
        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {

            return RedirectToLocal(returnUrl);


            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true

        }


        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
           
            return RedirectToAction("Index", "Home");
        }
        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model,string returnUrl)
        {
            Profile profile=new Profile();
            profile.Email = model.Email;
            profile.UserName = model.Name;
            profile.Password = model.Password;
            profile.Phone = model.Phone;
            profile.DOB = model.DOB;
            profile.Location = model.Location;
            profile.Gender = model.Gender;
            profile.Role = 1;

            var user = new User(profile);
            await UsersBL.Instance.Create(user);
            return RedirectToLocal(returnUrl);
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
