using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientSideDevDemo.Controllers
{
    public class TestsController : Controller
    {
        //
        // GET: /Tests/

        public ActionResult Index()
        {
            var testFiles = Directory.EnumerateFiles(Server.MapPath("~/Scripts/spec")).Where(f => f.EndsWith(".js"));
            var sutFiles = testFiles.Select(s => s.Replace("_spec", ""));
            ViewBag.SutFiles = sutFiles;
            ViewBag.TestFiles = testFiles;

            return View();
        }

    }
}
