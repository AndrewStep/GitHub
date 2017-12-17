using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarStore.WEBUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Summary()//передать сюда модель откуда будут братся пароли
        {
            return PartialView();
        }
    }
}