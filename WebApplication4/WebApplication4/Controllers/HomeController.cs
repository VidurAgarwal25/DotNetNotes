using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        public ActionResult Name()
        {
            return View();
        }
        public ActionResult Address()
        {
            return View("Address");
        }

        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Name = "Vidur agarwal",
                Address = "147/d old mohanpuri"
            };
        }
    }
}