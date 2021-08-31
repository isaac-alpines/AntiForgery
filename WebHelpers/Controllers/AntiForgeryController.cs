using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelpers.Models;

namespace WebHelpers.Controllers
{
    public class AntiForgeryController : Controller
    {
        public ActionResult Test()
        {
            return View(Database.listData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Test(int id)
        {
            Database.listData.RemoveAt(id);

            return RedirectToAction("test");
        }

        public ActionResult FakeTest()
        {
            return View(Database.listData);
        }
    }
}