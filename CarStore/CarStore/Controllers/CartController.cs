using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.DAL.Entities;

namespace CarStore.WEBUI.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}