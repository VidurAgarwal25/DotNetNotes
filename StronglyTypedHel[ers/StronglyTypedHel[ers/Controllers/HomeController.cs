using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedHel_ers.Models;

namespace StronglyTypedHel_ers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Address = "Pune",
                isEmployee = true,
                Name = "Vidur"
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View(emp);
        }
    }
}