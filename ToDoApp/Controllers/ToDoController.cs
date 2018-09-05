using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Task> tasks = DbContextService.db.Tasks;
            ViewBag.Tasks = tasks;
            return View();
        }
        //[HttpGet]
        //public ActionResult Index(string q)
        //{
        //    return View();
        //}
        //[HttpDelete]
        //public ActionResult Delete()
        //{
        //    return View();
        //}
        //[HttpPut]
        //public ActionResult Put()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Post()
        //{
        //    return View();
        //}
    }
}