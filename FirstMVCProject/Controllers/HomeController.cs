using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Redirect("http://oakacademy.uk/");
        }

        public ActionResult FirstAction()
        {
            return View();
        }

        public ActionResult GoToProduct()
        {
            //Opperations
            //return RedirectToAction("Product/AddProduct");
            //return RedirectToAction("Index");
            return RedirectToAction("AddProduct", "Product");
        }

        public ActionResult GoToUpdateProduct()
        {
            return RedirectToAction("UpdateProduct", "Product", new { ID = 20 });
        }
    }
}