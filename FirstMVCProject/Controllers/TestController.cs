using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    [RoutePrefix("test")]
    public class TestController : Controller
    {
        // GET: Test
        [Route]
        public ActionResult Index()
        {
            return View();
        }
        [Route("addtest")]
        public ActionResult Add()
        {
            return View();
        }
    }
}