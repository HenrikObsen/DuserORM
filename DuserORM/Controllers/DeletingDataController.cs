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
        CategoryFac cf = new CategoryFac();

        public ActionResult DeleteList()
        {
            return View(cf.GetAll());
        }

        public ActionResult Delete(int id)
        {
            cf.Delete(id);

            return RedirectToAction("DeleteList");
        }

        public ActionResult DeleteBySQL()
        {
            bf.ExecuteSQL("Delete from Beer where Name='Bad Beer'");
            return View();
        }
    }
}