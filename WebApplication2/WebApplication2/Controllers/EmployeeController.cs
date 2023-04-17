using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string Profile(int id)
        {
            if (id == 1)
                return "Profile1";
          
                return "ProfileAny";
        }
        public string Information(int id,int? code=null)
        {
            return "Employee id is " + id + " and code is " + code;
        }
    }
}