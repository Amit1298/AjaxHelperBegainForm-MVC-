using AjaxHelperBegainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelperBegainForm.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(employee e)
        {
            if(ModelState.IsValid == true)
            {
                db.employees.Add(e);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    return Json("Data Inserted");   //JavaScript Object Notation
                }
                else
                {
                    return Json("Data not Inserted");
                }
            }
            return View();
        }
    }
}