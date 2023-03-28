using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryvalues = categoryManager.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categortyvalidator=new CategoryValidator();
            ValidationResult result=categortyvalidator.Validate(p);
            if (result.IsValid) 
            {
                categoryManager.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage); 
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id) 
        {
            var values=categoryManager.GetByID(id);
            categoryManager.CategoryDelete(values);
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id) 
        {
            var categoryvalues=categoryManager.GetByID(id);
            return View(categoryvalues);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            categoryManager.CategoryUpdate(p);
         
                return RedirectToAction("Index");
        }
    }
}