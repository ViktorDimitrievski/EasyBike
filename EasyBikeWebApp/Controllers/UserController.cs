using Application.Implementation;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyBikeWebApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyProfile()
        {
            return View(userService.GetByUserName(HttpContext.User.Identity.Name));
        }
    }
}