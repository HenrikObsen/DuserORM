using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuserORM.Controllers
{
    public class GettingDataController : Controller
    {
        BeerFac bf = new BeerFac();

        public ActionResult GetARow()
        {
            return View(bf.Get(3));
        }

        public ActionResult GetAValue()
        {
            return View(bf.Get(2).Name);
        }

        public ActionResult GetAllRows()
        {
            return View(bf.GetAll());
        }

        public ActionResult GetAllOrderBy()
        {
            return View(bf.GetAll("Name","DESC"));
        }

        public ActionResult GetXamound()
        {
            return View(bf.GetAll("ID", "DESC", 4));
        }

        public ActionResult GetByColumnValue()
        {
            return View(bf.GetBy("Name", "Toxic Waste"));
        }

        public ActionResult GetBySQL()
        {
            return View(bf.ExecuteSQL<Beer>("select * from Beer"));
        }


    }
}