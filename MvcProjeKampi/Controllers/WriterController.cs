﻿using BusinessLayer.Concrete;
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
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writervalidator = new WriterValidator();
        public ActionResult Index()
        {
            var writervalues = wm.GetList();
            return View(writervalues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {    
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            
            ValidationResult result = writervalidator.Validate(writer);
            if(result.IsValid) 
            {
                 wm.WriterAdd(writer);
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
        [HttpGet]
        public ActionResult EditWriter(int id) 
        {
        var writervalue=wm.GetByID(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer writer)
        {
            ValidationResult result = writervalidator.Validate(writer);
            if (result.IsValid)
            {
                wm.WriterUpdate(writer);
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
    }
}