using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Entities;
using BLL;

namespace Application.Controllers
{
    /// <summary>
    /// User Profile Controller
    /// </summary>
    /// <create>
    /// ThamDTH - 2016/05/06
    /// </create>
    public class UserProfileController : Controller
    {
        // GET: UserProfile

        public async Task<ActionResult> UserProfilePage(string id)
        {

            var user = await UsersBL.Instance.FindById(id);
            return View(user.Profile);
        }
        [HttpPost]
        public async Task<ActionResult> UserProfilePage(string id, Profile profile)
        {
            var user = await UsersBL.Instance.FindById(id);
            user.Profile = profile;
            await UsersBL.Instance.Save(user);
            return RedirectToAction("Index", "Home");
        }
    }
}