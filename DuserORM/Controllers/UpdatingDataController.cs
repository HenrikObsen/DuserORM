using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuserORM.Controllers
{
    public class UpdatingDataController : Controller
    {
        CategoryFac cf = new CategoryFac();

        public ActionResult UpdateList()
        {
            return View(cf.GetAll());
        }

        public ActionResult UpdateForm(int id)
        {
            return View(cf.Get(id));
        }

        public ActionResult UpdateResult(Category c)
        {
            cf.Update(c);

            return RedirectToAction("UpdateList");
        }
    }

}