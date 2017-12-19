using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    
    public class HomeController : Controller
    {
        public ViewResult Contact()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public ViewResult About()
        {
            return View();
        }

        public ViewResult Payment()
        {
            return View();
        }
    }
}