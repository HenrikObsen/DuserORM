using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuserORM.Controllers
{
    public class DeletingDataController : Controller
    {
        BeerFac bf = new BeerFac();

        public ActionResult DeleteBySQL()
        {
            bf.ExecuteSQL("Delete from Beer where Name='Bad Beer'");
            return View();
        }
    }
}