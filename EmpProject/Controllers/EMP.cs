using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpProject.Controllers
{
    public class EMP : Controller
    {
        // GET: EMP
        [HttpGet]
        public ActionResult EmployeeEntry()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult EmployeeEntry(string EName, string EDeg, decimal Salary, int Age)
        //{

        //    return View();
        //}
    }
}