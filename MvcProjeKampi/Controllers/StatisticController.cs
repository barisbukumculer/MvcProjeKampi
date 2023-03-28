using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        public ActionResult Index()
        {
            Context context = new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.yazilimheadingCount = context.Headings.Where(c => c.Category.CategoryName=="Yazılım").Count();
            ViewBag.AWriters =(from x in context.Writers where x.WriterName.Contains("a") select x).ToList().Count();

            ViewBag.maxheadingCategory = context.Headings.OrderBy(x => x.CategoryID).GroupBy(y => y.Category.CategoryName).Select(z => new { KategoriAdı =z.Key,ToplamBaşlıkSayısı=z.Count()}).OrderByDescending(x=>x.ToplamBaşlıkSayısı).First();

            ViewBag.falseandtruecategory = context.Categories.Where(x => x.CategoryStatus == true).Count() - context.Categories.Where(x => x.CategoryStatus == false).Count();
           
            return View();
        }
    }
}