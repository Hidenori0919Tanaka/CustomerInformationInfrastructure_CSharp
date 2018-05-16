using CII_Reserch.CosmosDB_Manage;
using CII_Reserch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CII_Reserch.Controllers
{
    public class HomeController : Controller
    {
        private MongoDB_Manage dal = new MongoDB_Manage();
        private bool disposed = false;
        //
        // GET: /MyTask/

        public ActionResult MongoIndex()
        {
            return View(dal.GetAllTasks());
        }

        //
        // GET: /MyTask/Create

        public ActionResult MongoCreate()
        {
            return View();
        }

        //
        // POST: /MyTask/Create

        [HttpPost]
        public ActionResult MongoCreate(MyTask task)
        {
            try
            {
                dal.CreateTask(task);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        # region IDisposable

        new protected void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        new protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dal.Dispose();
                }
            }

            this.disposed = true;
        }

        # endregion

        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult MongoTest()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}