using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wman.Data;
using Wman.Models;

namespace Wman.Controllers
{
    public class WmanController : Controller
    {
        private readonly ApplicationDbcontext db;
        public WmanController( ApplicationDbcontext db)
        {

            this.db = db;
        }
        public IActionResult Index()
        {
            var wwm = db.Tables./*Include( obj=>obj.DepartmentId) */ToList();
            return View(wwm);
        }  

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TableOfWman tableOfWman)
        {

            TableOfWman wman = new TableOfWman();

            wman.NameOfWman = tableOfWman.NameOfWman;
            wman.AgeOfWman = tableOfWman.AgeOfWman;

            db.Tables.Add(wman);
            db.SaveChanges();


            return RedirectToAction("Index");
        }


        public IActionResult Delete (int id)
        {
            var wwm = db.Tables.Find(id);
            db.Tables.Remove(wwm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]

        public IActionResult Edit(int id)
        {
            var student = db.Tables.Find(id);

            return View(student);
        }


        [HttpPost]

        public IActionResult Edit(TableOfWman model)
        {
            var stu = db.Tables.Find(model.Id);

            stu.NameOfWman = model.NameOfWman;
            stu.AgeOfWman = model.AgeOfWman;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
