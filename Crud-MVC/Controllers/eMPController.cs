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
            var displaydata = _db.EmployeeTable.ToList();
            return View();
        }
    }
}
