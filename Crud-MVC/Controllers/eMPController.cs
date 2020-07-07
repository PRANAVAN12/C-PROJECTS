 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_MVC.Controllers
{
    public class eMPController : Controller
    {
        private readonly AppilicationDbContext _db;
       public eMPController(AppilicationDbContext  db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            
            var displaydata = _db.EmployeTable.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewEmpClass nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id== null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.EmployeTable.FindAsync(id);
            return View(getempdetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewEmpClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.EmployeTable.FindAsync(id);
            return View(getempdetails);
        }

    }
}
