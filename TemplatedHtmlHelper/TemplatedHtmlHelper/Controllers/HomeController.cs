using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHtmlHelper.Models;

namespace TemplatedHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Vidur",
                Email = "vidur025agarwal@gmail.com",
                DateOfBirth = DateTime.Now,
                IsOnline = true
            };
            return View(employee);
        }
    }
}