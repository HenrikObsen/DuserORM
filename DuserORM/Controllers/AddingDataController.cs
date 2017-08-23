using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuserORM.Controllers
{
    public class AddingDataController : Controller
    {
        CategoryFac cf = new CategoryFac();

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category c)
        {
            if (ModelState.IsValid)
            {
                cf.Insert(c);
                ViewBag.MSG = "Kategorien er oprettet!!!";
            }
            else
            {
                ViewBag.MSG = "Alle felter skal udfyldes!!!";
            }
            return View();
        }
    }
}