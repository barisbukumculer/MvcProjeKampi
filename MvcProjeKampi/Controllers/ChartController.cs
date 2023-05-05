using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryChart()
        {
            var statistics = new List<CategoryStatistic>
        {
            new CategoryStatistic { CategoryName = "Yazılım", CategoryCount = 8 },
            new CategoryStatistic { CategoryName = "Seyahat", CategoryCount = 4 },
            new CategoryStatistic { CategoryName = "Teknoloji", CategoryCount = 7 },
            new CategoryStatistic { CategoryName = "Spor", CategoryCount = 1 },
        };
            return Json(statistics, JsonRequestBehavior.AllowGet);
        }

    }

}