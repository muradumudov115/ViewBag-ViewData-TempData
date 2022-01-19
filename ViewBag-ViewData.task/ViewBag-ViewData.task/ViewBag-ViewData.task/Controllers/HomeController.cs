using DataTransferPart2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DataTransferPart2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

         {

            #region ViewBag,ViewData,TempData;
            // ViewBag.Name = "Lorem";
            //List<Student> stu = new List<Student>
            //{
            //    new Student{Id=1,Name="Murad",Age=18},
            //    new Student{Id=2,Name="Kamran",Age=18},
            //    new Student{Id=3,Name="Khanish",Age=17},
            //};
            // ViewBag.Students = stu;
            //  ViewData["students"] = stu;

            //ViewBag.Name = "Ibrahim";
            //ViewData["LastName"] = "Aliyev";
            //TempData["Age"] = 27;
            //return RedirectToAction("About");
            //return RedirectToAction( nameof(About));
            #endregion
            List<Student> stu = new List<Student>
             {
                new Student{Id=1,Name="Murad",Age=18},
                new Student{Id=2,Name="Kamran",Age=18},
                new Student{Id=3,Name="Khanish",Age=17},
            };
            return View(stu);



        }
        public IActionResult About()
        {
            TempData["Age"] = 27;

            return View();
        }
    }
}
