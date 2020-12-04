using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.DomainModels;
using TicketSystem.ServiceLayer;

namespace TicketSystem.Controllers
{
    public class AccountController : Controller
    {

        private  IUserService _service;


        public AccountController(IUserService service)
        {
            _service = service;
        }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                var userDetails = _service.Login(user.Emaild);

                if (userDetails.Type.ToLower() == "admin")
                {
                    return View("admin");
                }
                else
                {
                    var agent = _service.GetAgent(userDetails.Id);

                    ViewBag.name = agent.Name;
                    return View("customer");
                }
            }
            
        }

        public ActionResult Logout()
        {
            return View("Login");
        }
    }
}