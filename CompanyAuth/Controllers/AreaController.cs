using System;
using System.Collections.Generic;
using System.Linq;
using CompanyAuth.Data;
using CompanyAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyAuth.Controllers
{
    [Authorize]
    public class AreaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AreaController( ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var lista = _context.Area.ToList();
            return View(lista);
        }
        public IActionResult Edit(int id)
        {
            var edit = _context.Area.Where(p => p.Id == id).FirstOrDefault();
            return View(edit);
        }
        public IActionResult New()
        {
            var newArea = new Area(); 
            return View(newArea);
        }
        public IActionResult Delete(int id)
        {
            var delete = _context.Area.Where(p => p.Id == id).FirstOrDefault();
            return View(delete);
        }
        [HttpPost]
        public ActionResult Edit(Area area)
        {
            if (ModelState.IsValid)
            {
               var edit = _context.Area.Find(area.Id);
                edit.ArenaName = area.ArenaName;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(area);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(Area area)
        {
            if (ModelState.IsValid)
            {
                _context.Add(area);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(area);
            }
        }

        [HttpPost]
        public ActionResult Delete( Area area)
        {

            if (area == null)
            {
                return NotFound();
            }
            else
            {
                _context.Area.Remove(area);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
