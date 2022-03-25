//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Wman.Data;

//namespace Wman.Controllers
//{
//    public class Dep : Controller
//    {
        

//        public Dep(ApplicationDbcontext db)
//        {
//            this.db = db;
//        }

//        private readonly ApplicationDbcontext db;




//        public IActionResult Index()
//        {
//            var wwm = db.Departments.ToList();
//            return View(wwm);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Create(Dep tableOfWman)
//        {

//            TableOfWman wman = new TableOfWman();

//            wman.NameOfWman = tableOfWman.NameOfWman;
//            wman.AgeOfWman = tableOfWman.AgeOfWman;

//            db.Tables.Add(wman);
//            db.SaveChanges();


//            return RedirectToAction("Index");
//        }
//    }
//}
