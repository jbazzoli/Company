using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyAuth.Data;
using CompanyAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyAuth.Controllers
{
    [Authorize]
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
           
            _context = context;
           
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
           
            var lista = _context.Person.Include(p => p.Area);
            return View(await lista.ToListAsync());
        }
        public IActionResult Edit(int id)
        {
            var edit = _context.Person.Where(p => p.Id == id).FirstOrDefault();
            ViewData["AreaId"] = new SelectList(_context.Area, "Id", "ArenaName", edit.AreaId);
            return View(edit);
        }
        public IActionResult New()
        {
            var newPerson = new Person();
            ViewData["AreaId"] = new SelectList(_context.Area,"Id", "ArenaName");
            return View(newPerson);
        }
        public IActionResult Delete(int id)
        {
            var delete = _context.Person.Where(p => p.Id == id).FirstOrDefault();
            return View(delete);
        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {
             ViewData["AreaId"] = new SelectList(_context.Area, "Id", "AreaName");
            
            if (ModelState.IsValid)
            {
                var editPerson = _context.Person.Find(person.Id);
                editPerson.Name = person.Name;
                editPerson.Surname = person.Surname;
                editPerson.Salary = person.Salary;
                editPerson.FiscalCode = person.FiscalCode;
                editPerson.AreaId = person.AreaId;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(person);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(Person person)
        {
            var personSave = new Person()
            {
                Name = person.Name,
                Surname = person.Surname,
                FiscalCode = person.FiscalCode,
                Salary = person.Salary,
                AreaId = person.AreaId,
                Area = null
            };
            if (ModelState.IsValid)
            {
                _context.Add(personSave);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(person);
            }
        }

        [HttpPost]
        public ActionResult Delete(Person person)
        {
            person.Area =null;
            if (person == null)
            {
                return NotFound();
            }
            else
            {
                _context.Person.Remove(person);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
